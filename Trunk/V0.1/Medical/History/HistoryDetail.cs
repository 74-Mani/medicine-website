﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using Medical.Common.Exceptions;
using Medical.Data;
using Medical.Data.Entities;
using Medical.Data.Repositories;
using Medical.Forms.UI;

namespace Medical.History {
    public partial class HistoryDetail : Form {

        private readonly long _prescriptionId;
        private Prescription _prescription;
        private List<PrescriptionDetail> _prescriptionDetails;
        private readonly IMedicineDeliveryRepository _medicineDeliveryRepo = new MedicineDeliveryRepository();
        private readonly Boolean _isEditable;
        private readonly IFigureRepository _figureRepo = new FigureRepository();

        private readonly IPrescriptionRepository _prescriptionRepo = new PrescriptionRepository();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryDetail"/> class.
        /// </summary>
        /// <param name="prescriptionId">The _prescription id.</param>
        public HistoryDetail(long prescriptionId) {
            this.InitializeComponent();
            this._prescriptionId = prescriptionId;
            var delivered = _medicineDeliveryRepo.GetByPrescriptionId(_prescriptionId);
            this._isEditable = delivered == null;
        }

        /// <summary>
        /// Handles the Load event of the HistoryDetail control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void HistoryDetailLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Initialize()
        {
            this.btnDelete.Enabled = (this._isEditable);
            this._prescription = this._prescriptionRepo.Get(this._prescriptionId);

            var figures = _figureRepo.GetByClinicId(AppContext.CurrentClinic.Id);
            this.cboFigure.DataSource = figures;

            this.bdsPrescription.DataSource = this._prescription;
            foreach (var item in this._prescription.PrescriptionDetails)
            {
                item.TradeName = item.Medicine.TradeName;
                item.MedicineName = item.Medicine.Name;
                item.UnitName= item.Medicine.Define.Name;
            }
            this.bdsPrescriptionDetail.DataSource = this._prescription.PrescriptionDetails;
        }

        /// <summary>
        /// Handles the Click event of the btnClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void BtnCloseClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void BtnDeleteClick(object sender, EventArgs e)
        {
            var parameter = String.Format("đơn thuốc ngày {0} của bệnh nhân {1}",
                                                this._prescription.Date.ToString("dd/MM/yyyy"),
                                                this._prescription.PatientName);

            if (MessageDialog.Instance.ShowMessage(this, "Q003", parameter) == DialogResult.No) return;

            try {
                this._prescriptionRepo.Delete(this._prescriptionId);
                this.Close();
            } catch (ProgramLogicalException ex) {
                MessageDialog.Instance.ShowMessage(this, "ERR0001", ex.Message);
            }
        }

        /// <summary>
        /// Datas the grid view x1 data binding complete.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="DataGridViewBindingCompleteEventArgs"/> instance containing the event data.</param>
        private void DataGridViewX1DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridViewX)sender;
            if (null == gridView) return;
            foreach (DataGridViewRow r in gridView.Rows)
            {
                gridView.Rows[r.Index].HeaderCell.Value = (r.Index + 1).ToString();
            }
        }
    }
}

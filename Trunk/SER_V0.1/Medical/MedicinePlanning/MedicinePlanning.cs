﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using Medical.Data;
using Medical.Data.Entities;
using Medical.Data.Repositories;
using WeifenLuo.WinFormsUI.Docking;

namespace Medical.MedicinePlanning {
    public partial class MedicinePlanning : DockContent
    {
        private readonly IClinicRepository _clinicRepo = new ClinicRepository();
        private readonly IUserRepository _userRepo = new UserRepository();
        private readonly IMedicinePlanRepository _medicinePlanRepo = new MedicinePlanRepository();


        /// <summary>
        /// Initializes a new instance of the <see cref="MedicinePlanning"/> class.
        /// </summary>
        public MedicinePlanning() {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Initialize()
        {
            // Init Clinic combobox
            var clinic = this._clinicRepo.GetAll();
            clinic.Insert(0, new Clinic(){Id = 0, Name = "Tất cả"});
            this.bdsClinic.DataSource = clinic;
            this.cboClinic.SelectedValue = AppContext.CurrentClinic.Id;

            // Set current year for first time initialize
            this.txtYear.Value = DateTime.Today.Year;

            this.bdsStatus.DataSource = MedicinePlaningStatus.GetPlanningStatus();
            this.bdsUser.DataSource = this._userRepo.GetAll();

            InitializeData();
        }

        /// <summary>
        /// Initializes the data.
        /// </summary>
        private void InitializeData()
        {
            var planningList = _medicinePlanRepo.Get(this.ClinicId, this.Year, this.Month);
            this.bdsPlanning.DataSource = planningList;
            this.bdsPlanning.ResetBindings(true);
            this.dataGridViewX1.ResetBindings();
            this.dataGridViewX1.Refresh();
        }

        /// <summary>
        /// Medicines the planning load.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MedicinePlanningLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        /// <summary>
        /// BTNs the add planning click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnAddPlanningClick(object sender, EventArgs e)
        {
            var detail =new MedicinePlanningDetail();
            detail.ShowDialog(this);
        }

        private int? ClinicId
        {
            get { return this.cboClinic.SelectedValue == null ? (int?)null : Convert.ToInt32(this.cboClinic.SelectedValue); }
        }

        private int? Year
        {
            get { return this.txtYear.ValueObject == null ? (int?)null : this.txtYear.Value; }
        }

        private int? Month
        {
            get { return this.txtMonth.ValueObject == null ? (int?)null : this.txtMonth.Value; }
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

        /// <summary>
        /// Datas the grid view x1 cell double click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void DataGridViewX1CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var plan = (Data.Entities.MedicinePlan) this.bdsPlanning.Current;
            if (plan == null) return;

            var medicinePlanningDetail = new MedicinePlanningDetail(plan.Id);
            medicinePlanningDetail.ShowDialog(this);
        }

        /// <summary>
        /// TXTs the month value changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtMonthValueChanged(object sender, EventArgs e)
        {
            InitializeData();
        }

        /// <summary>
        /// TXTs the year value changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtYearValueChanged(object sender, EventArgs e)
        {
            InitializeData();
        }

        /// <summary>
        /// Cboes the clinic selected index changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CboClinicSelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeData();
        }
    }
}

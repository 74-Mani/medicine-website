﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Medical.Data;
using Medical.Data.Entities;
using Medical.Data.EntitiyExtend;
using Medical.Data.Repositories;
using WeifenLuo.WinFormsUI.Docking;

namespace Medical.MedicineForm
{
    public partial class FrmMedicine : DockContent
    {
        public static int IdMedicine = -1;
        private UserRepository _userRepository = new UserRepository();

        private readonly MedicineRepository _medicineRepository = new MedicineRepository();
        private readonly IDefineRepository _defineRepository = new DefineRepository();


        /// <summary>
        /// Initializes a new instance of the <see cref="FrmMedicine"/> class.
        /// </summary>
        public FrmMedicine()
        {
            InitializeComponent();
            
        }

        private void Initialize()
        {
            var items = new List<Item>(new Item[] { new Item(0, "Tất cả"), new Item(1, "ARV"), new Item(2, "NTCH") });
            this.cboType.ComboBox.DisplayMember = "Name";
            this.cboType.ComboBox.ValueMember = "Value";
            this.cboType.ComboBox.DataSource = items;
            this.cboType.ComboBox.SelectedValueChanged += new EventHandler(ComboBox_SelectedValueChanged);


            var units = _defineRepository.GetContentUnit();
            this.bdsDefine.DataSource = units;

        }

        private void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            FillToGrid();
        }

        /// <summary>
        /// Fills to grid.
        /// </summary>
        private void FillToGrid()
        {
            var type = Convert.ToInt32(this.cboType.ComboBox.SelectedValue);
            var medicines = _medicineRepository.Get(type);
            var index = 0;
            foreach (var item in medicines) item.No = ++index;
            this.bdsMedicines.DataSource = medicines;
        }

        /// <summary>
        /// Handles the Click event of the btnInsert control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            var frmedit = new FrmMedicinEdit();
            frmedit.ShowDialog();
            FillToGrid();
            
        }

        /// <summary>
        /// Handles the Click event of the btnDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((lblID.Text == "") || (lblID.Text == "0"))
            {
                MessageBox.Show("Bạn hãy chọn bản thuốc cần xóa!");
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa thuốc này không?", "Xóa thuốc", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                _medicineRepository.Delete(int.Parse(lblID.Text.Trim()));
                FillToGrid();
            }
        }

        /// <summary>
        /// Handles the Click event of the btnEdit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.bdsDefine.EndEdit();
            var medicine = (Medicine) this.bdsMedicines.Current;
            if (medicine == null) return;

            var frmedit = new FrmMedicinEdit(medicine.Id);
            frmedit.ShowDialog();
            FillToGrid();
        }


        /// <summary>
        /// Handles the Load event of the FrmMedicine control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void FrmMedicine_Load(object sender, EventArgs e)
        {
            FillToGrid();
            Initialize();
        }
    }
}

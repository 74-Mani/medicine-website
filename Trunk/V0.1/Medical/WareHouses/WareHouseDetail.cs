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
using Medical.Data.Repositories;

namespace Medical.WareHouses {
    public partial class WareHouseDetail : Form
    {
        private int warehouseId;

        private IDefineRepository defineRepo = new DefineRepository();
        private IMedicineRepository medicineRepo = new MedicineRepository();
        private IWareHouseRepository warehouseRepo = new WareHouseRepository();
        private IVWareHouseDetailRespository vwarehouseDetailRepo = new VWareHouseDetailRepository();

        public WareHouseDetail(int id) {
            InitializeComponent();
            this.warehouseId = id;
            Initialize();
        }

        private void Initialize()
        {
            this.bdsUnit.DataSource = this.defineRepo.GetUnit();
        }

        private void WareHouseDetailLoad(object sender, EventArgs e)
        {
            var warehouse = this.warehouseRepo.Get(this.warehouseId);
            if (warehouse == null) throw new Exception("Không tồn tại số dư trong kho");

            this.bdsMedicine.DataSource = warehouse.Medicine;
            this.bdsWarehouse.DataSource = warehouse;

            var warehouseDetail = this.vwarehouseDetailRepo.GetByMedicine(warehouse.MedicineId, warehouse.ClinicId);
            this.bdsWareHouseDetail.DataSource = warehouseDetail;
        }

        private void DataGridViewX1DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridViewX)sender;
            if (null == gridView) return;
            foreach (DataGridViewRow r in gridView.Rows)
            {
                gridView.Rows[r.Index].HeaderCell.Value = (r.Index + 1).ToString();
            }
        }

        private void ButtonX1Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

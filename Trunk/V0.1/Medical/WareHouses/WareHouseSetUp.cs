﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Medical.Data;
using Medical.Data.Repositories;
using Medical.Forms.UI;

namespace Medical.WareHouses
{
    public partial class WareHouseSetUp : Form
    {

        private int warehouseId;
        private Medical.Data.Entities.WareHouse warehouse;
        private IWareHouseRepository _warehouseRepo = new WareHouseRepository();

        /// <summary>
        /// Initializes a new instance of the <see cref="WareHouseSetUp"/> class.
        /// </summary>
        /// <param name="warehouseId">The warehouse id.</param>
        public WareHouseSetUp(int warehouseId)
        {
            InitializeComponent();
            this.warehouseId = warehouseId;
            warehouse = _warehouseRepo.GetById(warehouseId);
            bdsWarehouse.DataSource = warehouse;
        }

        /// <summary>
        /// BTNs the close click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// BTNs the save click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnSaveClick(object sender, EventArgs e)
        {
            try
            {
                var result = MessageDialog.Instance.ShowMessage(this, "Q011");
                if (result == DialogResult.No) return;
                _warehouseRepo.Update(this.warehouse);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageDialog.Instance.ShowMessage(this, "ERR0002", ex.Message);
            }
        }
    }
}

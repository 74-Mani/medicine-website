﻿namespace Medical
{
	partial class CheckUp
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckUp));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtSeachName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bdsPatient = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX6 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX14 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX7 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX9 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bdsPrescription = new System.Windows.Forms.BindingSource(this.components);
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX10 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX11 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX12 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.medicineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumnPerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsPrescriptionDetail = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxX15 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheck = new DevComponents.DotNetBar.ButtonX();
            this.btnCheckingHistory = new DevComponents.DotNetBar.ButtonX();
            this.btnRegister = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPrescriptionDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(18, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(50, 16);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Họ và tên";
            // 
            // txtSeachName
            // 
            this.txtSeachName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSeachName.Border.Class = "TextBoxBorder";
            this.txtSeachName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSeachName.ButtonCustom.DisplayPosition = 1;
            this.txtSeachName.ButtonCustom.Image = global::Medical.Properties.Resources.grey_search;
            this.txtSeachName.ButtonCustom.Visible = true;
            this.txtSeachName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPatient, "Name", true));
            this.txtSeachName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeachName.ForeColor = System.Drawing.Color.Black;
            this.txtSeachName.Location = new System.Drawing.Point(97, 18);
            this.txtSeachName.Name = "txtSeachName";
            this.txtSeachName.ReadOnly = true;
            this.txtSeachName.Size = new System.Drawing.Size(200, 22);
            this.txtSeachName.TabIndex = 0;
            this.txtSeachName.ButtonCustomClick += new System.EventHandler(this.TextBoxX1ButtonCustomClick);
            // 
            // bdsPatient
            // 
            this.bdsPatient.DataSource = typeof(Medical.Data.Entities.Patient);
            // 
            // textBoxX2
            // 
            this.textBoxX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPatient, "Code", true));
            this.textBoxX2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX2.ForeColor = System.Drawing.Color.Black;
            this.textBoxX2.Location = new System.Drawing.Point(97, 68);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.ReadOnly = true;
            this.textBoxX2.Size = new System.Drawing.Size(200, 20);
            this.textBoxX2.TabIndex = 4;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(19, 71);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(18, 15);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Mã";
            // 
            // textBoxX3
            // 
            this.textBoxX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPatient, "BirthYear", true));
            this.textBoxX3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX3.ForeColor = System.Drawing.Color.Black;
            this.textBoxX3.Location = new System.Drawing.Point(97, 96);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.ReadOnly = true;
            this.textBoxX3.Size = new System.Drawing.Size(200, 20);
            this.textBoxX3.TabIndex = 6;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(19, 96);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(49, 15);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Năm sinh";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(409, 153);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(36, 15);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Địa chỉ";
            // 
            // textBoxX5
            // 
            this.textBoxX5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX5.Border.Class = "TextBoxBorder";
            this.textBoxX5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPatient, "Phone", true));
            this.textBoxX5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX5.ForeColor = System.Drawing.Color.Black;
            this.textBoxX5.Location = new System.Drawing.Point(97, 122);
            this.textBoxX5.Name = "textBoxX5";
            this.textBoxX5.ReadOnly = true;
            this.textBoxX5.Size = new System.Drawing.Size(200, 20);
            this.textBoxX5.TabIndex = 8;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(19, 122);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(52, 15);
            this.labelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Điện thoại";
            // 
            // textBoxX6
            // 
            this.textBoxX6.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX6.Border.Class = "TextBoxBorder";
            this.textBoxX6.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPatient, "StartDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "dd/MM/yyyy"));
            this.textBoxX6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX6.ForeColor = System.Drawing.Color.Black;
            this.textBoxX6.Location = new System.Drawing.Point(97, 150);
            this.textBoxX6.Name = "textBoxX6";
            this.textBoxX6.ReadOnly = true;
            this.textBoxX6.Size = new System.Drawing.Size(200, 20);
            this.textBoxX6.TabIndex = 10;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(19, 150);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(70, 15);
            this.labelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "Ngày đăng ký";
            // 
            // textBoxX1
            // 
            this.textBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.ButtonCustom.DisplayPosition = 1;
            this.textBoxX1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPatient, "Name", true));
            this.textBoxX1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX1.ForeColor = System.Drawing.Color.Black;
            this.textBoxX1.Location = new System.Drawing.Point(486, 68);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.ReadOnly = true;
            this.textBoxX1.Size = new System.Drawing.Size(200, 20);
            this.textBoxX1.TabIndex = 5;
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(409, 71);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(50, 15);
            this.labelX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX8.TabIndex = 19;
            this.labelX8.Text = "Họ và tên";
            // 
            // textBoxX14
            // 
            this.textBoxX14.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX14.Border.Class = "TextBoxBorder";
            this.textBoxX14.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPatient, "ClinicName", true));
            this.textBoxX14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX14.ForeColor = System.Drawing.Color.Black;
            this.textBoxX14.Location = new System.Drawing.Point(486, 122);
            this.textBoxX14.Name = "textBoxX14";
            this.textBoxX14.ReadOnly = true;
            this.textBoxX14.Size = new System.Drawing.Size(200, 20);
            this.textBoxX14.TabIndex = 9;
            // 
            // labelX15
            // 
            this.labelX15.AutoSize = true;
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.Class = "";
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX15.Location = new System.Drawing.Point(409, 125);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(64, 15);
            this.labelX15.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX15.TabIndex = 17;
            this.labelX15.Text = "Phòng khám";
            // 
            // textBoxX4
            // 
            this.textBoxX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.textBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPatient, "Address", true));
            this.textBoxX4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX4.ForeColor = System.Drawing.Color.Black;
            this.textBoxX4.Location = new System.Drawing.Point(486, 150);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.ReadOnly = true;
            this.textBoxX4.Size = new System.Drawing.Size(200, 20);
            this.textBoxX4.TabIndex = 11;
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(409, 99);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(45, 15);
            this.labelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX7.TabIndex = 12;
            this.labelX7.Text = "Giới tính";
            // 
            // textBoxX7
            // 
            this.textBoxX7.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX7.Border.Class = "TextBoxBorder";
            this.textBoxX7.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPatient, "Sex", true));
            this.textBoxX7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX7.ForeColor = System.Drawing.Color.Black;
            this.textBoxX7.Location = new System.Drawing.Point(486, 96);
            this.textBoxX7.Name = "textBoxX7";
            this.textBoxX7.ReadOnly = true;
            this.textBoxX7.Size = new System.Drawing.Size(200, 20);
            this.textBoxX7.TabIndex = 7;
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(19, 212);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(58, 15);
            this.labelX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX9.TabIndex = 13;
            this.labelX9.Text = "Ngày khám";
            // 
            // textBoxX9
            // 
            this.textBoxX9.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX9.Border.Class = "TextBoxBorder";
            this.textBoxX9.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPrescription, "Date", true));
            this.textBoxX9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX9.ForeColor = System.Drawing.Color.Black;
            this.textBoxX9.Location = new System.Drawing.Point(97, 209);
            this.textBoxX9.Name = "textBoxX9";
            this.textBoxX9.ReadOnly = true;
            this.textBoxX9.Size = new System.Drawing.Size(200, 20);
            this.textBoxX9.TabIndex = 12;
            // 
            // bdsPrescription
            // 
            this.bdsPrescription.DataSource = typeof(Medical.Data.Entities.Prescription);
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(409, 239);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(33, 15);
            this.labelX10.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX10.TabIndex = 15;
            this.labelX10.Text = "Bác sĩ";
            // 
            // textBoxX10
            // 
            this.textBoxX10.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX10.Border.Class = "TextBoxBorder";
            this.textBoxX10.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPrescription, "DoctorName", true));
            this.textBoxX10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX10.ForeColor = System.Drawing.Color.Black;
            this.textBoxX10.Location = new System.Drawing.Point(486, 236);
            this.textBoxX10.Name = "textBoxX10";
            this.textBoxX10.ReadOnly = true;
            this.textBoxX10.Size = new System.Drawing.Size(200, 20);
            this.textBoxX10.TabIndex = 15;
            // 
            // labelX11
            // 
            this.labelX11.AutoSize = true;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(18, 265);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(53, 15);
            this.labelX11.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX11.TabIndex = 17;
            this.labelX11.Text = "Tình trạng";
            // 
            // labelX12
            // 
            this.labelX12.AutoSize = true;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.Class = "";
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(19, 239);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(43, 15);
            this.labelX12.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX12.TabIndex = 19;
            this.labelX12.Text = "Phác đồ";
            // 
            // textBoxX11
            // 
            this.textBoxX11.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX11.Border.Class = "TextBoxBorder";
            this.textBoxX11.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPrescription, "FigureName", true));
            this.textBoxX11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX11.ForeColor = System.Drawing.Color.Black;
            this.textBoxX11.Location = new System.Drawing.Point(97, 236);
            this.textBoxX11.Name = "textBoxX11";
            this.textBoxX11.ReadOnly = true;
            this.textBoxX11.Size = new System.Drawing.Size(200, 20);
            this.textBoxX11.TabIndex = 14;
            // 
            // textBoxX12
            // 
            this.textBoxX12.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX12.Border.Class = "TextBoxBorder";
            this.textBoxX12.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPrescription, "Note", true));
            this.textBoxX12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX12.ForeColor = System.Drawing.Color.Black;
            this.textBoxX12.Location = new System.Drawing.Point(97, 265);
            this.textBoxX12.Multiline = true;
            this.textBoxX12.Name = "textBoxX12";
            this.textBoxX12.ReadOnly = true;
            this.textBoxX12.Size = new System.Drawing.Size(652, 132);
            this.textBoxX12.TabIndex = 16;
            // 
            // labelX13
            // 
            this.labelX13.AutoSize = true;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.Class = "";
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX13.Location = new System.Drawing.Point(409, 209);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(67, 15);
            this.labelX13.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX13.TabIndex = 22;
            this.labelX13.Text = "Hẹn tái khám";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.AllowUserToResizeColumns = false;
            this.dataGridViewX1.AllowUserToResizeRows = false;
            this.dataGridViewX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewX1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicineNameDataGridViewTextBoxColumn,
            this.TradeName,
            this.UnitName,
            this.volumnPerDayDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridViewX1.DataSource = this.bdsPrescriptionDetail;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(97, 407);
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewX1.Size = new System.Drawing.Size(652, 243);
            this.dataGridViewX1.TabIndex = 17;
            this.dataGridViewX1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewX1DataBindingComplete);
            // 
            // medicineNameDataGridViewTextBoxColumn
            // 
            this.medicineNameDataGridViewTextBoxColumn.DataPropertyName = "MedicineName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            this.medicineNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.medicineNameDataGridViewTextBoxColumn.HeaderText = "Tên biệt dược";
            this.medicineNameDataGridViewTextBoxColumn.Name = "medicineNameDataGridViewTextBoxColumn";
            this.medicineNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.medicineNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // TradeName
            // 
            this.TradeName.DataPropertyName = "TradeName";
            this.TradeName.HeaderText = "Hoạt chất";
            this.TradeName.Name = "TradeName";
            this.TradeName.ReadOnly = true;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "Đơn vị";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            this.UnitName.Width = 80;
            // 
            // volumnPerDayDataGridViewTextBoxColumn
            // 
            this.volumnPerDayDataGridViewTextBoxColumn.DataPropertyName = "VolumnPerDay";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.volumnPerDayDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.volumnPerDayDataGridViewTextBoxColumn.HeaderText = "Liều lượng";
            this.volumnPerDayDataGridViewTextBoxColumn.Name = "volumnPerDayDataGridViewTextBoxColumn";
            this.volumnPerDayDataGridViewTextBoxColumn.ReadOnly = true;
            this.volumnPerDayDataGridViewTextBoxColumn.Width = 90;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dayDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dayDataGridViewTextBoxColumn.HeaderText = "Ngày thuốc";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayDataGridViewTextBoxColumn.Width = 90;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Tổng số";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bdsPrescriptionDetail
            // 
            this.bdsPrescriptionDetail.DataSource = typeof(Medical.Data.Entities.PrescriptionDetail);
            // 
            // textBoxX15
            // 
            this.textBoxX15.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX15.Border.Class = "TextBoxBorder";
            this.textBoxX15.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPrescription, "RecheckDate", true));
            this.textBoxX15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX15.ForeColor = System.Drawing.Color.Black;
            this.textBoxX15.Location = new System.Drawing.Point(486, 207);
            this.textBoxX15.Name = "textBoxX15";
            this.textBoxX15.ReadOnly = true;
            this.textBoxX15.Size = new System.Drawing.Size(200, 20);
            this.textBoxX15.TabIndex = 13;
            // 
            // labelX14
            // 
            this.labelX14.AutoSize = true;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX14.Location = new System.Drawing.Point(19, 407);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(54, 15);
            this.labelX14.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX14.TabIndex = 24;
            this.labelX14.Text = "Đơn thuốc";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(852, 2);
            this.label1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(22, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(852, 2);
            this.label2.TabIndex = 28;
            // 
            // btnCheck
            // 
            this.btnCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheck.Image = global::Medical.Properties.Resources.kham;
            this.btnCheck.Location = new System.Drawing.Point(515, 19);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 21);
            this.btnCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Khám bệnh";
            this.btnCheck.Click += new System.EventHandler(this.BtnCheckClick);
            // 
            // btnCheckingHistory
            // 
            this.btnCheckingHistory.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckingHistory.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckingHistory.Image = global::Medical.Properties.Resources.doctor_suitecase_26;
            this.btnCheckingHistory.Location = new System.Drawing.Point(409, 19);
            this.btnCheckingHistory.Name = "btnCheckingHistory";
            this.btnCheckingHistory.Size = new System.Drawing.Size(100, 21);
            this.btnCheckingHistory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckingHistory.TabIndex = 2;
            this.btnCheckingHistory.Text = "Y bạ";
            this.btnCheckingHistory.Click += new System.EventHandler(this.BtnCheckingHistoryClick);
            // 
            // btnRegister
            // 
            this.btnRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRegister.Image = global::Medical.Properties.Resources.add_user;
            this.btnRegister.Location = new System.Drawing.Point(303, 19);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 21);
            this.btnRegister.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Đăng kí";
            this.btnRegister.Click += new System.EventHandler(this.BtnRegisterClick);
            // 
            // CheckUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(896, 679);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.labelX14);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.textBoxX15);
            this.Controls.Add(this.textBoxX11);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.textBoxX12);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.textBoxX10);
            this.Controls.Add(this.labelX13);
            this.Controls.Add(this.textBoxX14);
            this.Controls.Add(this.btnCheckingHistory);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX9);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtSeachName);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX15);
            this.Controls.Add(this.textBoxX4);
            this.Controls.Add(this.textBoxX7);
            this.Controls.Add(this.textBoxX6);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.textBoxX5);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.textBoxX3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(773, 37);
            this.Name = "CheckUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Khám bệnh";
            this.Load += new System.EventHandler(this.CheckUpLoad);
            ((System.ComponentModel.ISupportInitialize)(this.bdsPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPrescriptionDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.BindingSource bdsPatient;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSeachName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX5;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX6;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX7;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX11;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX12;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX14;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX15;
        private DevComponents.DotNetBar.ButtonX btnCheck;
        private DevComponents.DotNetBar.ButtonX btnCheckingHistory;
        private DevComponents.DotNetBar.ButtonX btnRegister;
        private System.Windows.Forms.BindingSource bdsPrescription;
        private System.Windows.Forms.BindingSource bdsPrescriptionDetail;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumnPerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
	}
}
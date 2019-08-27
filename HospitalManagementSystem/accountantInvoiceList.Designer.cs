namespace HospitalManagementSystem
{
    partial class accountantInvoiceList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTileAdminEmployee = new MetroFramework.Controls.MetroTile();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.hMSSDataSet8 = new HospitalManagementSystem.HMSSDataSet8();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new HospitalManagementSystem.HMSSDataSet8TableAdapters.InvoiceTableAdapter();
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPatientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDoctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRoomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDateOfAdmitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDateOfReleaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAdmissionChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iServiceChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDoctorFeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRoomChargePerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRoomForDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iVatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTotalBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSSDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTileAdminEmployee
            // 
            this.metroTileAdminEmployee.ActiveControl = null;
            this.metroTileAdminEmployee.Location = new System.Drawing.Point(23, 19);
            this.metroTileAdminEmployee.Name = "metroTileAdminEmployee";
            this.metroTileAdminEmployee.Size = new System.Drawing.Size(77, 50);
            this.metroTileAdminEmployee.TabIndex = 30;
            this.metroTileAdminEmployee.Text = "Back";
            this.metroTileAdminEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminEmployee.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminEmployee.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminEmployee.UseCustomForeColor = true;
            this.metroTileAdminEmployee.UseSelectable = true;
            this.metroTileAdminEmployee.UseTileImage = true;
            this.metroTileAdminEmployee.Click += new System.EventHandler(this.metroTileAdminEmployee_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIDDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.iPatientNameDataGridViewTextBoxColumn,
            this.iDoctorNameDataGridViewTextBoxColumn,
            this.iRoomNoDataGridViewTextBoxColumn,
            this.iDateOfAdmitionDataGridViewTextBoxColumn,
            this.iDateOfReleaseDataGridViewTextBoxColumn,
            this.iAdmissionChargeDataGridViewTextBoxColumn,
            this.iServiceChargeDataGridViewTextBoxColumn,
            this.iDoctorFeesDataGridViewTextBoxColumn,
            this.iRoomChargePerDayDataGridViewTextBoxColumn,
            this.iRoomForDaysDataGridViewTextBoxColumn,
            this.iVatDataGridViewTextBoxColumn,
            this.iDiscountDataGridViewTextBoxColumn,
            this.iTotalBillDataGridViewTextBoxColumn,
            this.loginIDDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.invoiceBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 93);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(804, 150);
            this.metroGrid1.TabIndex = 31;
            // 
            // hMSSDataSet8
            // 
            this.hMSSDataSet8.DataSetName = "HMSSDataSet8";
            this.hMSSDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.hMSSDataSet8;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            this.invoiceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceDateDataGridViewTextBoxColumn
            // 
            this.invoiceDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            this.invoiceDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iPatientNameDataGridViewTextBoxColumn
            // 
            this.iPatientNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iPatientNameDataGridViewTextBoxColumn.DataPropertyName = "I_PatientName";
            this.iPatientNameDataGridViewTextBoxColumn.HeaderText = "I_PatientName";
            this.iPatientNameDataGridViewTextBoxColumn.Name = "iPatientNameDataGridViewTextBoxColumn";
            this.iPatientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDoctorNameDataGridViewTextBoxColumn
            // 
            this.iDoctorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDoctorNameDataGridViewTextBoxColumn.DataPropertyName = "I_DoctorName";
            this.iDoctorNameDataGridViewTextBoxColumn.HeaderText = "I_DoctorName";
            this.iDoctorNameDataGridViewTextBoxColumn.Name = "iDoctorNameDataGridViewTextBoxColumn";
            this.iDoctorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iRoomNoDataGridViewTextBoxColumn
            // 
            this.iRoomNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iRoomNoDataGridViewTextBoxColumn.DataPropertyName = "I_RoomNo";
            this.iRoomNoDataGridViewTextBoxColumn.HeaderText = "I_RoomNo";
            this.iRoomNoDataGridViewTextBoxColumn.Name = "iRoomNoDataGridViewTextBoxColumn";
            this.iRoomNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDateOfAdmitionDataGridViewTextBoxColumn
            // 
            this.iDateOfAdmitionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDateOfAdmitionDataGridViewTextBoxColumn.DataPropertyName = "I_DateOfAdmition";
            this.iDateOfAdmitionDataGridViewTextBoxColumn.HeaderText = "I_DateOfAdmition";
            this.iDateOfAdmitionDataGridViewTextBoxColumn.Name = "iDateOfAdmitionDataGridViewTextBoxColumn";
            this.iDateOfAdmitionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDateOfReleaseDataGridViewTextBoxColumn
            // 
            this.iDateOfReleaseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDateOfReleaseDataGridViewTextBoxColumn.DataPropertyName = "I_DateOfRelease";
            this.iDateOfReleaseDataGridViewTextBoxColumn.HeaderText = "I_DateOfRelease";
            this.iDateOfReleaseDataGridViewTextBoxColumn.Name = "iDateOfReleaseDataGridViewTextBoxColumn";
            this.iDateOfReleaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iAdmissionChargeDataGridViewTextBoxColumn
            // 
            this.iAdmissionChargeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iAdmissionChargeDataGridViewTextBoxColumn.DataPropertyName = "I_AdmissionCharge";
            this.iAdmissionChargeDataGridViewTextBoxColumn.HeaderText = "I_AdmissionCharge";
            this.iAdmissionChargeDataGridViewTextBoxColumn.Name = "iAdmissionChargeDataGridViewTextBoxColumn";
            this.iAdmissionChargeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iServiceChargeDataGridViewTextBoxColumn
            // 
            this.iServiceChargeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iServiceChargeDataGridViewTextBoxColumn.DataPropertyName = "I_ServiceCharge";
            this.iServiceChargeDataGridViewTextBoxColumn.HeaderText = "I_ServiceCharge";
            this.iServiceChargeDataGridViewTextBoxColumn.Name = "iServiceChargeDataGridViewTextBoxColumn";
            this.iServiceChargeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDoctorFeesDataGridViewTextBoxColumn
            // 
            this.iDoctorFeesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDoctorFeesDataGridViewTextBoxColumn.DataPropertyName = "I_DoctorFees";
            this.iDoctorFeesDataGridViewTextBoxColumn.HeaderText = "I_DoctorFees";
            this.iDoctorFeesDataGridViewTextBoxColumn.Name = "iDoctorFeesDataGridViewTextBoxColumn";
            this.iDoctorFeesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iRoomChargePerDayDataGridViewTextBoxColumn
            // 
            this.iRoomChargePerDayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iRoomChargePerDayDataGridViewTextBoxColumn.DataPropertyName = "I_RoomChargePerDay";
            this.iRoomChargePerDayDataGridViewTextBoxColumn.HeaderText = "I_RoomChargePerDay";
            this.iRoomChargePerDayDataGridViewTextBoxColumn.Name = "iRoomChargePerDayDataGridViewTextBoxColumn";
            this.iRoomChargePerDayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iRoomForDaysDataGridViewTextBoxColumn
            // 
            this.iRoomForDaysDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iRoomForDaysDataGridViewTextBoxColumn.DataPropertyName = "I_RoomForDays";
            this.iRoomForDaysDataGridViewTextBoxColumn.HeaderText = "I_RoomForDays";
            this.iRoomForDaysDataGridViewTextBoxColumn.Name = "iRoomForDaysDataGridViewTextBoxColumn";
            this.iRoomForDaysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iVatDataGridViewTextBoxColumn
            // 
            this.iVatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iVatDataGridViewTextBoxColumn.DataPropertyName = "I_Vat";
            this.iVatDataGridViewTextBoxColumn.HeaderText = "I_Vat";
            this.iVatDataGridViewTextBoxColumn.Name = "iVatDataGridViewTextBoxColumn";
            this.iVatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDiscountDataGridViewTextBoxColumn
            // 
            this.iDiscountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDiscountDataGridViewTextBoxColumn.DataPropertyName = "I_Discount";
            this.iDiscountDataGridViewTextBoxColumn.HeaderText = "I_Discount";
            this.iDiscountDataGridViewTextBoxColumn.Name = "iDiscountDataGridViewTextBoxColumn";
            this.iDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTotalBillDataGridViewTextBoxColumn
            // 
            this.iTotalBillDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iTotalBillDataGridViewTextBoxColumn.DataPropertyName = "I_TotalBill";
            this.iTotalBillDataGridViewTextBoxColumn.HeaderText = "I_TotalBill";
            this.iTotalBillDataGridViewTextBoxColumn.Name = "iTotalBillDataGridViewTextBoxColumn";
            this.iTotalBillDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginIDDataGridViewTextBoxColumn
            // 
            this.loginIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loginIDDataGridViewTextBoxColumn.DataPropertyName = "LoginID";
            this.loginIDDataGridViewTextBoxColumn.HeaderText = "LoginID";
            this.loginIDDataGridViewTextBoxColumn.Name = "loginIDDataGridViewTextBoxColumn";
            this.loginIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountantInvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroTileAdminEmployee);
            this.Name = "accountantInvoiceList";
            this.Text = "Invoice List";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.accountantInvoiceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSSDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileAdminEmployee;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private HMSSDataSet8 hMSSDataSet8;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private HMSSDataSet8TableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPatientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDoctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRoomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDateOfAdmitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDateOfReleaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAdmissionChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iServiceChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDoctorFeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRoomChargePerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRoomForDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iVatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTotalBillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginIDDataGridViewTextBoxColumn;
    }
}
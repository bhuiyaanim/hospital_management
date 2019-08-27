namespace HospitalManagementSystem
{
    partial class RecepPatientList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTileAdminEmployee = new MetroFramework.Controls.MetroTile();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBloodGrooupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientRoomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDateOfAdmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDateOfReleaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDoctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSSDataSet11 = new HospitalManagementSystem.HMSSDataSet11();
            this.patientTableAdapter = new HospitalManagementSystem.HMSSDataSet11TableAdapters.PatientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSSDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTileAdminEmployee
            // 
            this.metroTileAdminEmployee.ActiveControl = null;
            this.metroTileAdminEmployee.Location = new System.Drawing.Point(23, 23);
            this.metroTileAdminEmployee.Name = "metroTileAdminEmployee";
            this.metroTileAdminEmployee.Size = new System.Drawing.Size(62, 44);
            this.metroTileAdminEmployee.TabIndex = 21;
            this.metroTileAdminEmployee.Text = "Back";
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
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.patientAgeDataGridViewTextBoxColumn,
            this.patientGenderDataGridViewTextBoxColumn,
            this.patientDateOfBirthDataGridViewTextBoxColumn,
            this.patientAddressDataGridViewTextBoxColumn,
            this.patientPhoneDataGridViewTextBoxColumn,
            this.patientBloodGrooupDataGridViewTextBoxColumn,
            this.patientRoomNoDataGridViewTextBoxColumn,
            this.patientDateOfAdmissionDataGridViewTextBoxColumn,
            this.patientDateOfReleaseDataGridViewTextBoxColumn,
            this.patientDoctorNameDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.patientBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.Location = new System.Drawing.Point(8, 73);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(838, 150);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGrid1.TabIndex = 22;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            this.patientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientAgeDataGridViewTextBoxColumn
            // 
            this.patientAgeDataGridViewTextBoxColumn.DataPropertyName = "PatientAge";
            this.patientAgeDataGridViewTextBoxColumn.HeaderText = "PatientAge";
            this.patientAgeDataGridViewTextBoxColumn.Name = "patientAgeDataGridViewTextBoxColumn";
            this.patientAgeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientGenderDataGridViewTextBoxColumn
            // 
            this.patientGenderDataGridViewTextBoxColumn.DataPropertyName = "PatientGender";
            this.patientGenderDataGridViewTextBoxColumn.HeaderText = "PatientGender";
            this.patientGenderDataGridViewTextBoxColumn.Name = "patientGenderDataGridViewTextBoxColumn";
            this.patientGenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientDateOfBirthDataGridViewTextBoxColumn
            // 
            this.patientDateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "PatientDateOfBirth";
            this.patientDateOfBirthDataGridViewTextBoxColumn.HeaderText = "PatientDateOfBirth";
            this.patientDateOfBirthDataGridViewTextBoxColumn.Name = "patientDateOfBirthDataGridViewTextBoxColumn";
            this.patientDateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientAddressDataGridViewTextBoxColumn
            // 
            this.patientAddressDataGridViewTextBoxColumn.DataPropertyName = "PatientAddress";
            this.patientAddressDataGridViewTextBoxColumn.HeaderText = "PatientAddress";
            this.patientAddressDataGridViewTextBoxColumn.Name = "patientAddressDataGridViewTextBoxColumn";
            this.patientAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientPhoneDataGridViewTextBoxColumn
            // 
            this.patientPhoneDataGridViewTextBoxColumn.DataPropertyName = "PatientPhone";
            this.patientPhoneDataGridViewTextBoxColumn.HeaderText = "PatientPhone";
            this.patientPhoneDataGridViewTextBoxColumn.Name = "patientPhoneDataGridViewTextBoxColumn";
            this.patientPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientBloodGrooupDataGridViewTextBoxColumn
            // 
            this.patientBloodGrooupDataGridViewTextBoxColumn.DataPropertyName = "PatientBloodGrooup";
            this.patientBloodGrooupDataGridViewTextBoxColumn.HeaderText = "PatientBloodGrooup";
            this.patientBloodGrooupDataGridViewTextBoxColumn.Name = "patientBloodGrooupDataGridViewTextBoxColumn";
            this.patientBloodGrooupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientRoomNoDataGridViewTextBoxColumn
            // 
            this.patientRoomNoDataGridViewTextBoxColumn.DataPropertyName = "PatientRoomNo";
            this.patientRoomNoDataGridViewTextBoxColumn.HeaderText = "PatientRoomNo";
            this.patientRoomNoDataGridViewTextBoxColumn.Name = "patientRoomNoDataGridViewTextBoxColumn";
            this.patientRoomNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientDateOfAdmissionDataGridViewTextBoxColumn
            // 
            this.patientDateOfAdmissionDataGridViewTextBoxColumn.DataPropertyName = "PatientDateOfAdmission";
            this.patientDateOfAdmissionDataGridViewTextBoxColumn.HeaderText = "PatientDateOfAdmission";
            this.patientDateOfAdmissionDataGridViewTextBoxColumn.Name = "patientDateOfAdmissionDataGridViewTextBoxColumn";
            this.patientDateOfAdmissionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientDateOfReleaseDataGridViewTextBoxColumn
            // 
            this.patientDateOfReleaseDataGridViewTextBoxColumn.DataPropertyName = "PatientDateOfRelease";
            this.patientDateOfReleaseDataGridViewTextBoxColumn.HeaderText = "PatientDateOfRelease";
            this.patientDateOfReleaseDataGridViewTextBoxColumn.Name = "patientDateOfReleaseDataGridViewTextBoxColumn";
            this.patientDateOfReleaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientDoctorNameDataGridViewTextBoxColumn
            // 
            this.patientDoctorNameDataGridViewTextBoxColumn.DataPropertyName = "PatientDoctorName";
            this.patientDoctorNameDataGridViewTextBoxColumn.HeaderText = "PatientDoctorName";
            this.patientDoctorNameDataGridViewTextBoxColumn.Name = "patientDoctorNameDataGridViewTextBoxColumn";
            this.patientDoctorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.hMSSDataSet11;
            // 
            // hMSSDataSet11
            // 
            this.hMSSDataSet11.DataSetName = "HMSSDataSet11";
            this.hMSSDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // RecepPatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroTileAdminEmployee);
            this.Name = "RecepPatientList";
            this.Text = "Patient List";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.RecepPatientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSSDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileAdminEmployee;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private HMSSDataSet11 hMSSDataSet11;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private HMSSDataSet11TableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientBloodGrooupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientRoomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDateOfAdmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDateOfReleaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDoctorNameDataGridViewTextBoxColumn;
    }
}
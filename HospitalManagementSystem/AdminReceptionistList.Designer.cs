namespace HospitalManagementSystem
{
    partial class AdminReceptionistList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminReceptionistList));
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.receptionistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSSDataSet5 = new HospitalManagementSystem.HMSSDataSet5();
            this.receptionistTableAdapter = new HospitalManagementSystem.HMSSDataSet5TableAdapters.ReceptionistTableAdapter();
            this.back = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSSDataSet5)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receptionistIDDataGridViewTextBoxColumn,
            this.receptionistNameDataGridViewTextBoxColumn,
            this.receptionistAddressDataGridViewTextBoxColumn,
            this.receptionistPhoneDataGridViewTextBoxColumn,
            this.receptionistAgeDataGridViewTextBoxColumn,
            this.receptionistGenderDataGridViewTextBoxColumn,
            this.receptionistSalaryDataGridViewTextBoxColumn,
            this.receptionistEmailDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.receptionistBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.Location = new System.Drawing.Point(10, 80);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidth = 50;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(830, 250);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // receptionistIDDataGridViewTextBoxColumn
            // 
            this.receptionistIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receptionistIDDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistID";
            this.receptionistIDDataGridViewTextBoxColumn.FillWeight = 89F;
            this.receptionistIDDataGridViewTextBoxColumn.HeaderText = "ReceptionistID";
            this.receptionistIDDataGridViewTextBoxColumn.Name = "receptionistIDDataGridViewTextBoxColumn";
            this.receptionistIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receptionistNameDataGridViewTextBoxColumn
            // 
            this.receptionistNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receptionistNameDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistName";
            this.receptionistNameDataGridViewTextBoxColumn.FillWeight = 108F;
            this.receptionistNameDataGridViewTextBoxColumn.HeaderText = "ReceptionistName";
            this.receptionistNameDataGridViewTextBoxColumn.Name = "receptionistNameDataGridViewTextBoxColumn";
            this.receptionistNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receptionistAddressDataGridViewTextBoxColumn
            // 
            this.receptionistAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receptionistAddressDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistAddress";
            this.receptionistAddressDataGridViewTextBoxColumn.FillWeight = 122F;
            this.receptionistAddressDataGridViewTextBoxColumn.HeaderText = "ReceptionistAddress";
            this.receptionistAddressDataGridViewTextBoxColumn.Name = "receptionistAddressDataGridViewTextBoxColumn";
            this.receptionistAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receptionistPhoneDataGridViewTextBoxColumn
            // 
            this.receptionistPhoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receptionistPhoneDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistPhone";
            this.receptionistPhoneDataGridViewTextBoxColumn.FillWeight = 115F;
            this.receptionistPhoneDataGridViewTextBoxColumn.HeaderText = "ReceptionistPhone";
            this.receptionistPhoneDataGridViewTextBoxColumn.Name = "receptionistPhoneDataGridViewTextBoxColumn";
            this.receptionistPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receptionistAgeDataGridViewTextBoxColumn
            // 
            this.receptionistAgeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receptionistAgeDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistAge";
            this.receptionistAgeDataGridViewTextBoxColumn.FillWeight = 101.3383F;
            this.receptionistAgeDataGridViewTextBoxColumn.HeaderText = "ReceptionistAge";
            this.receptionistAgeDataGridViewTextBoxColumn.Name = "receptionistAgeDataGridViewTextBoxColumn";
            this.receptionistAgeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receptionistGenderDataGridViewTextBoxColumn
            // 
            this.receptionistGenderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receptionistGenderDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistGender";
            this.receptionistGenderDataGridViewTextBoxColumn.FillWeight = 101.3383F;
            this.receptionistGenderDataGridViewTextBoxColumn.HeaderText = "ReceptionistGender";
            this.receptionistGenderDataGridViewTextBoxColumn.Name = "receptionistGenderDataGridViewTextBoxColumn";
            this.receptionistGenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receptionistSalaryDataGridViewTextBoxColumn
            // 
            this.receptionistSalaryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receptionistSalaryDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistSalary";
            this.receptionistSalaryDataGridViewTextBoxColumn.FillWeight = 101.3383F;
            this.receptionistSalaryDataGridViewTextBoxColumn.HeaderText = "ReceptionistSalary";
            this.receptionistSalaryDataGridViewTextBoxColumn.Name = "receptionistSalaryDataGridViewTextBoxColumn";
            this.receptionistSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receptionistEmailDataGridViewTextBoxColumn
            // 
            this.receptionistEmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receptionistEmailDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistEmail";
            this.receptionistEmailDataGridViewTextBoxColumn.FillWeight = 115F;
            this.receptionistEmailDataGridViewTextBoxColumn.HeaderText = "ReceptionistEmail";
            this.receptionistEmailDataGridViewTextBoxColumn.Name = "receptionistEmailDataGridViewTextBoxColumn";
            this.receptionistEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receptionistBindingSource
            // 
            this.receptionistBindingSource.DataMember = "Receptionist";
            this.receptionistBindingSource.DataSource = this.hMSSDataSet5;
            // 
            // hMSSDataSet5
            // 
            this.hMSSDataSet5.DataSetName = "HMSSDataSet5";
            this.hMSSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptionistTableAdapter
            // 
            this.receptionistTableAdapter.ClearBeforeFill = true;
            // 
            // back
            // 
            this.back.ActiveControl = null;
            this.back.Location = new System.Drawing.Point(25, 25);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(40, 20);
            this.back.Style = MetroFramework.MetroColorStyle.Yellow;
            this.back.TabIndex = 31;
            this.back.Text = "Back";
            this.back.TileImage = ((System.Drawing.Image)(resources.GetObject("back.TileImage")));
            this.back.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.back.UseCustomForeColor = true;
            this.back.UseSelectable = true;
            this.back.UseTileImage = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AdminReceptionistList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.back);
            this.Controls.Add(this.metroGrid1);
            this.Name = "AdminReceptionistList";
            this.Text = "Receptionist List";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AdminReceptionistList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSSDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private HMSSDataSet5 hMSSDataSet5;
        private System.Windows.Forms.BindingSource receptionistBindingSource;
        private HMSSDataSet5TableAdapters.ReceptionistTableAdapter receptionistTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistEmailDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile back;
    }
}
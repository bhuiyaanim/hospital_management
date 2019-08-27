namespace HospitalManagementSystem
{
    partial class AdminAccountList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAccountList));
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.accountantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSSDataSet4 = new HospitalManagementSystem.HMSSDataSet4();
            this.accountantTableAdapter = new HospitalManagementSystem.HMSSDataSet4TableAdapters.AccountantTableAdapter();
            this.back = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSSDataSet4)).BeginInit();
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
            this.accountantIDDataGridViewTextBoxColumn,
            this.accountantNameDataGridViewTextBoxColumn,
            this.accountantAddressDataGridViewTextBoxColumn,
            this.accountantPhoneDataGridViewTextBoxColumn,
            this.accountantSalaryDataGridViewTextBoxColumn,
            this.accountantAgeDataGridViewTextBoxColumn,
            this.accountantGenderDataGridViewTextBoxColumn,
            this.accountantEmailDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.accountantBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(10, 85);
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
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(830, 250);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroGrid1.UseCustomBackColor = true;
            // 
            // accountantIDDataGridViewTextBoxColumn
            // 
            this.accountantIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountantIDDataGridViewTextBoxColumn.DataPropertyName = "AccountantID";
            this.accountantIDDataGridViewTextBoxColumn.FillWeight = 160F;
            this.accountantIDDataGridViewTextBoxColumn.HeaderText = "AccountantID";
            this.accountantIDDataGridViewTextBoxColumn.Name = "accountantIDDataGridViewTextBoxColumn";
            this.accountantIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountantNameDataGridViewTextBoxColumn
            // 
            this.accountantNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountantNameDataGridViewTextBoxColumn.DataPropertyName = "AccountantName";
            this.accountantNameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.accountantNameDataGridViewTextBoxColumn.HeaderText = "AccountantName";
            this.accountantNameDataGridViewTextBoxColumn.Name = "accountantNameDataGridViewTextBoxColumn";
            this.accountantNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountantAddressDataGridViewTextBoxColumn
            // 
            this.accountantAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountantAddressDataGridViewTextBoxColumn.DataPropertyName = "AccountantAddress";
            this.accountantAddressDataGridViewTextBoxColumn.FillWeight = 205F;
            this.accountantAddressDataGridViewTextBoxColumn.HeaderText = "AccountantAddress";
            this.accountantAddressDataGridViewTextBoxColumn.Name = "accountantAddressDataGridViewTextBoxColumn";
            this.accountantAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountantPhoneDataGridViewTextBoxColumn
            // 
            this.accountantPhoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountantPhoneDataGridViewTextBoxColumn.DataPropertyName = "AccountantPhone";
            this.accountantPhoneDataGridViewTextBoxColumn.FillWeight = 200F;
            this.accountantPhoneDataGridViewTextBoxColumn.HeaderText = "AccountantPhone";
            this.accountantPhoneDataGridViewTextBoxColumn.Name = "accountantPhoneDataGridViewTextBoxColumn";
            this.accountantPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountantSalaryDataGridViewTextBoxColumn
            // 
            this.accountantSalaryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountantSalaryDataGridViewTextBoxColumn.DataPropertyName = "AccountantSalary";
            this.accountantSalaryDataGridViewTextBoxColumn.FillWeight = 200F;
            this.accountantSalaryDataGridViewTextBoxColumn.HeaderText = "AccountantSalary";
            this.accountantSalaryDataGridViewTextBoxColumn.Name = "accountantSalaryDataGridViewTextBoxColumn";
            this.accountantSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountantAgeDataGridViewTextBoxColumn
            // 
            this.accountantAgeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountantAgeDataGridViewTextBoxColumn.DataPropertyName = "AccountantAge";
            this.accountantAgeDataGridViewTextBoxColumn.FillWeight = 200F;
            this.accountantAgeDataGridViewTextBoxColumn.HeaderText = "AccountantAge";
            this.accountantAgeDataGridViewTextBoxColumn.Name = "accountantAgeDataGridViewTextBoxColumn";
            this.accountantAgeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountantGenderDataGridViewTextBoxColumn
            // 
            this.accountantGenderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountantGenderDataGridViewTextBoxColumn.DataPropertyName = "AccountantGender";
            this.accountantGenderDataGridViewTextBoxColumn.FillWeight = 210F;
            this.accountantGenderDataGridViewTextBoxColumn.HeaderText = "AccountantGender";
            this.accountantGenderDataGridViewTextBoxColumn.Name = "accountantGenderDataGridViewTextBoxColumn";
            this.accountantGenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountantEmailDataGridViewTextBoxColumn
            // 
            this.accountantEmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountantEmailDataGridViewTextBoxColumn.DataPropertyName = "AccountantEmail";
            this.accountantEmailDataGridViewTextBoxColumn.FillWeight = 210F;
            this.accountantEmailDataGridViewTextBoxColumn.HeaderText = "AccountantEmail";
            this.accountantEmailDataGridViewTextBoxColumn.Name = "accountantEmailDataGridViewTextBoxColumn";
            this.accountantEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountantBindingSource
            // 
            this.accountantBindingSource.DataMember = "Accountant";
            this.accountantBindingSource.DataSource = this.hMSSDataSet4;
            // 
            // hMSSDataSet4
            // 
            this.hMSSDataSet4.DataSetName = "HMSSDataSet4";
            this.hMSSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountantTableAdapter
            // 
            this.accountantTableAdapter.ClearBeforeFill = true;
            // 
            // back
            // 
            this.back.ActiveControl = null;
            this.back.Location = new System.Drawing.Point(25, 25);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(40, 20);
            this.back.Style = MetroFramework.MetroColorStyle.Yellow;
            this.back.TabIndex = 23;
            this.back.Text = "Back";
            this.back.TileImage = ((System.Drawing.Image)(resources.GetObject("back.TileImage")));
            this.back.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.back.UseCustomForeColor = true;
            this.back.UseSelectable = true;
            this.back.UseTileImage = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AdminAccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.back);
            this.Controls.Add(this.metroGrid1);
            this.Name = "AdminAccountList";
            this.Text = "Account List";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AdminAccountList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSSDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private HMSSDataSet4 hMSSDataSet4;
        private System.Windows.Forms.BindingSource accountantBindingSource;
        private HMSSDataSet4TableAdapters.AccountantTableAdapter accountantTableAdapter;
        private MetroFramework.Controls.MetroTile back;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountantNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountantAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountantPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountantSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountantAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountantGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountantEmailDataGridViewTextBoxColumn;
    }
}
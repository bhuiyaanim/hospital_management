namespace HospitalManagementSystem
{
    partial class accountantInvoiceForm
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
            this.metroTileAdminPatient = new MetroFramework.Controls.MetroTile();
            this.metroTileAdminEmployee = new MetroFramework.Controls.MetroTile();
            this.metroTileAdminProfile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileAdminPatient
            // 
            this.metroTileAdminPatient.ActiveControl = null;
            this.metroTileAdminPatient.Location = new System.Drawing.Point(245, 88);
            this.metroTileAdminPatient.Name = "metroTileAdminPatient";
            this.metroTileAdminPatient.Size = new System.Drawing.Size(180, 50);
            this.metroTileAdminPatient.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTileAdminPatient.TabIndex = 30;
            this.metroTileAdminPatient.Text = "Invoice List";
            this.metroTileAdminPatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminPatient.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminPatient.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminPatient.UseCustomForeColor = true;
            this.metroTileAdminPatient.UseSelectable = true;
            this.metroTileAdminPatient.UseTileImage = true;
            this.metroTileAdminPatient.Click += new System.EventHandler(this.metroTileAdminPatient_Click);
            // 
            // metroTileAdminEmployee
            // 
            this.metroTileAdminEmployee.ActiveControl = null;
            this.metroTileAdminEmployee.Location = new System.Drawing.Point(431, 88);
            this.metroTileAdminEmployee.Name = "metroTileAdminEmployee";
            this.metroTileAdminEmployee.Size = new System.Drawing.Size(180, 50);
            this.metroTileAdminEmployee.TabIndex = 29;
            this.metroTileAdminEmployee.Text = "Create Invoice";
            this.metroTileAdminEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminEmployee.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminEmployee.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminEmployee.UseCustomForeColor = true;
            this.metroTileAdminEmployee.UseSelectable = true;
            this.metroTileAdminEmployee.UseTileImage = true;
            this.metroTileAdminEmployee.Click += new System.EventHandler(this.metroTileAdminEmployee_Click);
            // 
            // metroTileAdminProfile
            // 
            this.metroTileAdminProfile.ActiveControl = null;
            this.metroTileAdminProfile.Location = new System.Drawing.Point(23, 28);
            this.metroTileAdminProfile.Name = "metroTileAdminProfile";
            this.metroTileAdminProfile.Size = new System.Drawing.Size(70, 44);
            this.metroTileAdminProfile.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileAdminProfile.TabIndex = 31;
            this.metroTileAdminProfile.Text = "Back";
            this.metroTileAdminProfile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminProfile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminProfile.UseCustomForeColor = true;
            this.metroTileAdminProfile.UseSelectable = true;
            this.metroTileAdminProfile.UseStyleColors = true;
            this.metroTileAdminProfile.UseTileImage = true;
            this.metroTileAdminProfile.Click += new System.EventHandler(this.metroTileAdminProfile_Click);
            // 
            // accountantInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.metroTileAdminProfile);
            this.Controls.Add(this.metroTileAdminPatient);
            this.Controls.Add(this.metroTileAdminEmployee);
            this.Name = "accountantInvoiceForm";
            this.Text = "Invoice";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.accountantInvoiceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileAdminPatient;
        private MetroFramework.Controls.MetroTile metroTileAdminEmployee;
        private MetroFramework.Controls.MetroTile metroTileAdminProfile;
    }
}
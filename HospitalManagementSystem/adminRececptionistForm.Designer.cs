namespace HospitalManagementSystem
{
    partial class adminRececptionistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminRececptionistForm));
            this.metroTileAdminProfile = new MetroFramework.Controls.MetroTile();
            this.metroTileAdminDate = new MetroFramework.Controls.MetroTile();
            this.back = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileAdminProfile
            // 
            this.metroTileAdminProfile.ActiveControl = null;
            this.metroTileAdminProfile.Location = new System.Drawing.Point(426, 90);
            this.metroTileAdminProfile.Name = "metroTileAdminProfile";
            this.metroTileAdminProfile.Size = new System.Drawing.Size(280, 50);
            this.metroTileAdminProfile.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileAdminProfile.TabIndex = 27;
            this.metroTileAdminProfile.Text = "Add Receptionist";
            this.metroTileAdminProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminProfile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminProfile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminProfile.UseCustomForeColor = true;
            this.metroTileAdminProfile.UseSelectable = true;
            this.metroTileAdminProfile.UseStyleColors = true;
            this.metroTileAdminProfile.UseTileImage = true;
            this.metroTileAdminProfile.Click += new System.EventHandler(this.metroTileAdminProfile_Click);
            // 
            // metroTileAdminDate
            // 
            this.metroTileAdminDate.ActiveControl = null;
            this.metroTileAdminDate.Location = new System.Drawing.Point(145, 90);
            this.metroTileAdminDate.Name = "metroTileAdminDate";
            this.metroTileAdminDate.Size = new System.Drawing.Size(280, 50);
            this.metroTileAdminDate.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTileAdminDate.TabIndex = 26;
            this.metroTileAdminDate.Text = "Receptionist List";
            this.metroTileAdminDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminDate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminDate.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminDate.UseCustomForeColor = true;
            this.metroTileAdminDate.UseSelectable = true;
            this.metroTileAdminDate.UseTileImage = true;
            this.metroTileAdminDate.Click += new System.EventHandler(this.metroTileAdminDate_Click);
            // 
            // back
            // 
            this.back.ActiveControl = null;
            this.back.Location = new System.Drawing.Point(25, 25);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(40, 20);
            this.back.Style = MetroFramework.MetroColorStyle.Yellow;
            this.back.TabIndex = 30;
            this.back.Text = "Back";
            this.back.TileImage = ((System.Drawing.Image)(resources.GetObject("back.TileImage")));
            this.back.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.back.UseCustomForeColor = true;
            this.back.UseSelectable = true;
            this.back.UseTileImage = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // adminRececptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.back);
            this.Controls.Add(this.metroTileAdminProfile);
            this.Controls.Add(this.metroTileAdminDate);
            this.Name = "adminRececptionistForm";
            this.Text = "Rececptionist";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.adminRececptionistForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileAdminProfile;
        private MetroFramework.Controls.MetroTile metroTileAdminDate;
        private MetroFramework.Controls.MetroTile back;
    }
}
namespace HospitalManagementSystem
{
    partial class Accountantform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accountantform));
            this.Profile = new MetroFramework.Controls.MetroTile();
            this.invoice = new MetroFramework.Controls.MetroTile();
            this.Dashboard = new MetroFramework.Controls.MetroTile();
            this.Salary1 = new MetroFramework.Controls.MetroTile();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.Date = new MetroFramework.Controls.MetroTile();
            this.Invoice1 = new MetroFramework.Controls.MetroTile();
            this.Logout = new MetroFramework.Controls.MetroTile();
            this.Time = new MetroFramework.Controls.MetroTile();
            this.Profile2 = new MetroFramework.Controls.MetroTile();
            this.Salary = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // Profile
            // 
            this.Profile.ActiveControl = null;
            this.Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Profile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Profile.Location = new System.Drawing.Point(3, 249);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(202, 60);
            this.Profile.TabIndex = 34;
            this.Profile.Text = "Profile";
            this.Profile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Profile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Profile.UseCustomForeColor = true;
            this.Profile.UseSelectable = true;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // invoice
            // 
            this.invoice.ActiveControl = null;
            this.invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.invoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.invoice.Location = new System.Drawing.Point(3, 125);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(202, 60);
            this.invoice.TabIndex = 33;
            this.invoice.Text = "Invoice";
            this.invoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.invoice.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.invoice.UseCustomForeColor = true;
            this.invoice.UseSelectable = true;
            this.invoice.Click += new System.EventHandler(this.invoice_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.ActiveControl = null;
            this.Dashboard.BackColor = System.Drawing.Color.Black;
            this.Dashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Dashboard.Location = new System.Drawing.Point(3, 63);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(202, 60);
            this.Dashboard.TabIndex = 32;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dashboard.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Dashboard.UseCustomForeColor = true;
            this.Dashboard.UseSelectable = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // Salary1
            // 
            this.Salary1.ActiveControl = null;
            this.Salary1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Salary1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Salary1.Location = new System.Drawing.Point(3, 187);
            this.Salary1.Name = "Salary1";
            this.Salary1.Size = new System.Drawing.Size(202, 60);
            this.Salary1.TabIndex = 39;
            this.Salary1.Text = "Salary";
            this.Salary1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Salary1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Salary1.UseCustomForeColor = true;
            this.Salary1.UseSelectable = true;
            this.Salary1.Click += new System.EventHandler(this.Salary1_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(639, 28);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(206, 29);
            this.metroDateTime1.TabIndex = 41;
            // 
            // Date
            // 
            this.Date.ActiveControl = null;
            this.Date.Location = new System.Drawing.Point(207, 352);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(211, 143);
            this.Date.TabIndex = 40;
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Date.TileImage = ((System.Drawing.Image)(resources.GetObject("Date.TileImage")));
            this.Date.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Date.UseCustomForeColor = true;
            this.Date.UseSelectable = true;
            this.Date.UseStyleColors = true;
            this.Date.UseTileImage = true;
            // 
            // Invoice1
            // 
            this.Invoice1.ActiveControl = null;
            this.Invoice1.BackColor = System.Drawing.Color.Black;
            this.Invoice1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Invoice1.Location = new System.Drawing.Point(207, 63);
            this.Invoice1.Name = "Invoice1";
            this.Invoice1.Size = new System.Drawing.Size(315, 287);
            this.Invoice1.Style = MetroFramework.MetroColorStyle.Blue;
            this.Invoice1.TabIndex = 31;
            this.Invoice1.Text = "Invoice";
            this.Invoice1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Invoice1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Invoice1.TileImage = ((System.Drawing.Image)(resources.GetObject("Invoice1.TileImage")));
            this.Invoice1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Invoice1.UseCustomForeColor = true;
            this.Invoice1.UseSelectable = true;
            this.Invoice1.UseTileImage = true;
            // 
            // Logout
            // 
            this.Logout.ActiveControl = null;
            this.Logout.BackColor = System.Drawing.Color.Black;
            this.Logout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Logout.Location = new System.Drawing.Point(633, 352);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(211, 143);
            this.Logout.Style = MetroFramework.MetroColorStyle.Black;
            this.Logout.TabIndex = 30;
            this.Logout.Text = "Logout";
            this.Logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Logout.TileImage = ((System.Drawing.Image)(resources.GetObject("Logout.TileImage")));
            this.Logout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Logout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Logout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Logout.UseSelectable = true;
            this.Logout.UseTileImage = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Time
            // 
            this.Time.ActiveControl = null;
            this.Time.Location = new System.Drawing.Point(420, 352);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(211, 143);
            this.Time.TabIndex = 37;
            this.Time.Text = "Time";
            this.Time.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Time.TileImage = ((System.Drawing.Image)(resources.GetObject("Time.TileImage")));
            this.Time.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Time.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Time.UseCustomForeColor = true;
            this.Time.UseSelectable = true;
            this.Time.UseStyleColors = true;
            this.Time.UseTileImage = true;
            // 
            // Profile2
            // 
            this.Profile2.ActiveControl = null;
            this.Profile2.BackColor = System.Drawing.Color.Black;
            this.Profile2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Profile2.Location = new System.Drawing.Point(524, 207);
            this.Profile2.Name = "Profile2";
            this.Profile2.Size = new System.Drawing.Size(321, 143);
            this.Profile2.TabIndex = 36;
            this.Profile2.Text = "Profile";
            this.Profile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Profile2.TileImage = ((System.Drawing.Image)(resources.GetObject("Profile2.TileImage")));
            this.Profile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Profile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Profile2.UseCustomForeColor = true;
            this.Profile2.UseSelectable = true;
            this.Profile2.UseStyleColors = true;
            this.Profile2.UseTileImage = true;
            this.Profile2.Click += new System.EventHandler(this.Profile2_Click);
            // 
            // Salary
            // 
            this.Salary.ActiveControl = null;
            this.Salary.Location = new System.Drawing.Point(524, 63);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(320, 143);
            this.Salary.TabIndex = 35;
            this.Salary.Text = "Salary";
            this.Salary.TileImage = ((System.Drawing.Image)(resources.GetObject("Salary.TileImage")));
            this.Salary.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Salary.UseCustomForeColor = true;
            this.Salary.UseSelectable = true;
            this.Salary.UseStyleColors = true;
            this.Salary.UseTileImage = true;
            this.Salary.Click += new System.EventHandler(this.Salary_Click);
            // 
            // Accountantform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Salary1);
            this.Controls.Add(this.Invoice1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Profile2);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.invoice);
            this.Controls.Add(this.Dashboard);
            this.Name = "Accountantform";
            this.Text = "Accountant";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Accountantform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile Invoice1;
        private MetroFramework.Controls.MetroTile Logout;
        private MetroFramework.Controls.MetroTile Time;
        private MetroFramework.Controls.MetroTile Profile2;
        private MetroFramework.Controls.MetroTile Salary;
        private MetroFramework.Controls.MetroTile Profile;
        private MetroFramework.Controls.MetroTile invoice;
        private MetroFramework.Controls.MetroTile Dashboard;
        private MetroFramework.Controls.MetroTile Salary1;
        private MetroFramework.Controls.MetroTile Date;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
    }
}
namespace HospitalManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.usernametf = new MetroFramework.Controls.MetroTextBox();
            this.passwordtf = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login = new MetroFramework.Controls.MetroTile();
            this.timedesign = new MetroFramework.Controls.MetroTile();
            this.Datedesign = new MetroFramework.Controls.MetroTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(710, 290);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(131, 32);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Login";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(710, 329);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(131, 32);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Forget Password??";
            this.metroButton2.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(639, 229);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "username";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.WrapToLine = true;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(639, 260);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 25);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "password";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.WrapToLine = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(438, 172);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(178, 268);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = resources.GetString("metroLabel2.Text");
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.WrapToLine = true;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // usernametf
            // 
            // 
            // 
            // 
            this.usernametf.CustomButton.Image = null;
            this.usernametf.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.usernametf.CustomButton.Name = "";
            this.usernametf.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.usernametf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernametf.CustomButton.TabIndex = 1;
            this.usernametf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernametf.CustomButton.UseSelectable = true;
            this.usernametf.CustomButton.Visible = false;
            this.usernametf.DisplayIcon = true;
            this.usernametf.IconRight = true;
            this.usernametf.Lines = new string[0];
            this.usernametf.Location = new System.Drawing.Point(707, 229);
            this.usernametf.MaxLength = 32767;
            this.usernametf.Name = "usernametf";
            this.usernametf.PasswordChar = '\0';
            this.usernametf.PromptText = "ex - admin";
            this.usernametf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernametf.SelectedText = "";
            this.usernametf.SelectionLength = 0;
            this.usernametf.SelectionStart = 0;
            this.usernametf.ShortcutsEnabled = true;
            this.usernametf.Size = new System.Drawing.Size(139, 25);
            this.usernametf.TabIndex = 10;
            this.usernametf.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.usernametf.UseSelectable = true;
            this.usernametf.WaterMark = "ex - admin";
            this.usernametf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernametf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.usernametf.Click += new System.EventHandler(this.usernametf_Click);
            // 
            // passwordtf
            // 
            // 
            // 
            // 
            this.passwordtf.CustomButton.Image = null;
            this.passwordtf.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.passwordtf.CustomButton.Name = "";
            this.passwordtf.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.passwordtf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordtf.CustomButton.TabIndex = 1;
            this.passwordtf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordtf.CustomButton.UseSelectable = true;
            this.passwordtf.CustomButton.Visible = false;
            this.passwordtf.DisplayIcon = true;
            this.passwordtf.IconRight = true;
            this.passwordtf.Lines = new string[0];
            this.passwordtf.Location = new System.Drawing.Point(707, 260);
            this.passwordtf.MaxLength = 32767;
            this.passwordtf.Name = "passwordtf";
            this.passwordtf.PasswordChar = '\0';
            this.passwordtf.PromptText = "ex - admin";
            this.passwordtf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordtf.SelectedText = "";
            this.passwordtf.SelectionLength = 0;
            this.passwordtf.SelectionStart = 0;
            this.passwordtf.ShortcutsEnabled = true;
            this.passwordtf.Size = new System.Drawing.Size(139, 25);
            this.passwordtf.TabIndex = 11;
            this.passwordtf.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.passwordtf.UseSelectable = true;
            this.passwordtf.WaterMark = "ex - admin";
            this.passwordtf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordtf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passwordtf.Click += new System.EventHandler(this.passwordtf_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HospitalManagementSystem.Properties.Resources.stethoscope_medium;
            this.pictureBox2.Location = new System.Drawing.Point(2, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(423, 344);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.medi_banner;
            this.pictureBox1.Location = new System.Drawing.Point(2, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(846, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.login.ActiveControl = null;
            this.login.BackColor = System.Drawing.Color.Indigo;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.ForeColor = System.Drawing.SystemColors.MenuText;
            this.login.Location = new System.Drawing.Point(639, 200);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(209, 61);
            this.login.Style = MetroFramework.MetroColorStyle.Purple;
            this.login.TabIndex = 29;
            this.login.Text = "Click Here to Log in";
            this.login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.login.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.login.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.login.UseCustomBackColor = true;
            this.login.UseCustomForeColor = true;
            this.login.UseSelectable = true;
            this.login.UseStyleColors = true;
            this.login.UseTileImage = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // timedesign
            // 
            this.timedesign.ActiveControl = null;
            this.timedesign.BackColor = System.Drawing.Color.Indigo;
            this.timedesign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timedesign.ForeColor = System.Drawing.SystemColors.MenuText;
            this.timedesign.Location = new System.Drawing.Point(639, 261);
            this.timedesign.Name = "timedesign";
            this.timedesign.Size = new System.Drawing.Size(209, 61);
            this.timedesign.Style = MetroFramework.MetroColorStyle.Purple;
            this.timedesign.TabIndex = 30;
            this.timedesign.Text = "Time";
            this.timedesign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timedesign.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timedesign.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timedesign.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.timedesign.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.timedesign.UseCustomBackColor = true;
            this.timedesign.UseCustomForeColor = true;
            this.timedesign.UseSelectable = true;
            this.timedesign.UseStyleColors = true;
            this.timedesign.UseTileImage = true;
            this.timedesign.Click += new System.EventHandler(this.timedesign_Click);
            // 
            // Datedesign
            // 
            this.Datedesign.ActiveControl = null;
            this.Datedesign.BackColor = System.Drawing.Color.Indigo;
            this.Datedesign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Datedesign.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Datedesign.Location = new System.Drawing.Point(639, 322);
            this.Datedesign.Name = "Datedesign";
            this.Datedesign.Size = new System.Drawing.Size(209, 57);
            this.Datedesign.Style = MetroFramework.MetroColorStyle.Purple;
            this.Datedesign.TabIndex = 31;
            this.Datedesign.Text = "Date";
            this.Datedesign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Datedesign.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Datedesign.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Datedesign.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Datedesign.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Datedesign.UseCustomBackColor = true;
            this.Datedesign.UseCustomForeColor = true;
            this.Datedesign.UseSelectable = true;
            this.Datedesign.UseStyleColors = true;
            this.Datedesign.UseTileImage = true;
            this.Datedesign.Click += new System.EventHandler(this.Datedesign_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.Datedesign);
            this.Controls.Add(this.timedesign);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordtf);
            this.Controls.Add(this.usernametf);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Name = "LoginForm";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox usernametf;
        private MetroFramework.Controls.MetroTextBox passwordtf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTile login;
        private MetroFramework.Controls.MetroTile timedesign;
        private MetroFramework.Controls.MetroTile Datedesign;
        private System.Windows.Forms.Timer timer1;
    }
}
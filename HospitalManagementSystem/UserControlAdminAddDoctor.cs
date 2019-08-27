using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace HospitalManagementSystem
{
    public partial class UserControlAdminAddDoctor : MetroFramework.Forms.MetroForm
    {
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTextBox adtb;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton submit;
        private MetroFramework.Controls.MetroTextBox satb;
        private MetroFramework.Controls.MetroTextBox phtb;
        private MetroFramework.Controls.MetroTextBox gntb;
        private MetroFramework.Controls.MetroTextBox agtb;
        private MetroFramework.Controls.MetroTextBox namtb;
        private MetroFramework.Controls.MetroTextBox idtb;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;

        public UserControlAdminAddDoctor()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAdminAddDoctor));
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.adtb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.submit = new MetroFramework.Controls.MetroButton();
            this.satb = new MetroFramework.Controls.MetroTextBox();
            this.phtb = new MetroFramework.Controls.MetroTextBox();
            this.gntb = new MetroFramework.Controls.MetroTextBox();
            this.agtb = new MetroFramework.Controls.MetroTextBox();
            this.namtb = new MetroFramework.Controls.MetroTextBox();
            this.idtb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(612, 36);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(206, 29);
            this.metroDateTime1.TabIndex = 60;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroTile2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTile2.Location = new System.Drawing.Point(81, 36);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(40, 20);
            this.metroTile2.TabIndex = 59;
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // adtb
            // 
            // 
            // 
            // 
            this.adtb.CustomButton.Image = null;
            this.adtb.CustomButton.Location = new System.Drawing.Point(272, 1);
            this.adtb.CustomButton.Name = "";
            this.adtb.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.adtb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.adtb.CustomButton.TabIndex = 1;
            this.adtb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.adtb.CustomButton.UseSelectable = true;
            this.adtb.CustomButton.Visible = false;
            this.adtb.Lines = new string[0];
            this.adtb.Location = new System.Drawing.Point(227, 298);
            this.adtb.MaxLength = 32767;
            this.adtb.Name = "adtb";
            this.adtb.PasswordChar = '\0';
            this.adtb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.adtb.SelectedText = "";
            this.adtb.SelectionLength = 0;
            this.adtb.SelectionStart = 0;
            this.adtb.ShortcutsEnabled = true;
            this.adtb.Size = new System.Drawing.Size(316, 45);
            this.adtb.TabIndex = 58;
            this.adtb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.adtb.UseSelectable = true;
            this.adtb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.adtb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(173, 420);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(12, 19);
            this.metroLabel14.TabIndex = 57;
            this.metroLabel14.Text = ":";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(173, 373);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(12, 19);
            this.metroLabel13.TabIndex = 56;
            this.metroLabel13.Text = ":";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(173, 309);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(12, 19);
            this.metroLabel12.TabIndex = 55;
            this.metroLabel12.Text = ":";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(173, 255);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(12, 19);
            this.metroLabel11.TabIndex = 54;
            this.metroLabel11.Text = ":";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(173, 208);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(12, 19);
            this.metroLabel10.TabIndex = 53;
            this.metroLabel10.Text = ":";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(173, 165);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(12, 19);
            this.metroLabel9.TabIndex = 52;
            this.metroLabel9.Text = ":";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(173, 119);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(12, 19);
            this.metroLabel8.TabIndex = 51;
            this.metroLabel8.Text = ":";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(663, 365);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 50;
            this.submit.Text = "Submit";
            this.submit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.submit.UseSelectable = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // satb
            // 
            // 
            // 
            // 
            this.satb.CustomButton.Image = null;
            this.satb.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.satb.CustomButton.Name = "";
            this.satb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.satb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.satb.CustomButton.TabIndex = 1;
            this.satb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.satb.CustomButton.UseSelectable = true;
            this.satb.CustomButton.Visible = false;
            this.satb.Lines = new string[0];
            this.satb.Location = new System.Drawing.Point(227, 416);
            this.satb.MaxLength = 32767;
            this.satb.Name = "satb";
            this.satb.PasswordChar = '\0';
            this.satb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.satb.SelectedText = "";
            this.satb.SelectionLength = 0;
            this.satb.SelectionStart = 0;
            this.satb.ShortcutsEnabled = true;
            this.satb.Size = new System.Drawing.Size(316, 23);
            this.satb.TabIndex = 48;
            this.satb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.satb.UseSelectable = true;
            this.satb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.satb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // phtb
            // 
            // 
            // 
            // 
            this.phtb.CustomButton.Image = null;
            this.phtb.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.phtb.CustomButton.Name = "";
            this.phtb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.phtb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phtb.CustomButton.TabIndex = 1;
            this.phtb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phtb.CustomButton.UseSelectable = true;
            this.phtb.CustomButton.Visible = false;
            this.phtb.Lines = new string[0];
            this.phtb.Location = new System.Drawing.Point(227, 365);
            this.phtb.MaxLength = 32767;
            this.phtb.Name = "phtb";
            this.phtb.PasswordChar = '\0';
            this.phtb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phtb.SelectedText = "";
            this.phtb.SelectionLength = 0;
            this.phtb.SelectionStart = 0;
            this.phtb.ShortcutsEnabled = true;
            this.phtb.Size = new System.Drawing.Size(316, 23);
            this.phtb.TabIndex = 47;
            this.phtb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.phtb.UseSelectable = true;
            this.phtb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phtb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gntb
            // 
            // 
            // 
            // 
            this.gntb.CustomButton.Image = null;
            this.gntb.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.gntb.CustomButton.Name = "";
            this.gntb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gntb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gntb.CustomButton.TabIndex = 1;
            this.gntb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gntb.CustomButton.UseSelectable = true;
            this.gntb.CustomButton.Visible = false;
            this.gntb.Lines = new string[0];
            this.gntb.Location = new System.Drawing.Point(227, 251);
            this.gntb.MaxLength = 32767;
            this.gntb.Name = "gntb";
            this.gntb.PasswordChar = '\0';
            this.gntb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gntb.SelectedText = "";
            this.gntb.SelectionLength = 0;
            this.gntb.SelectionStart = 0;
            this.gntb.ShortcutsEnabled = true;
            this.gntb.Size = new System.Drawing.Size(316, 23);
            this.gntb.TabIndex = 46;
            this.gntb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gntb.UseSelectable = true;
            this.gntb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gntb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // agtb
            // 
            // 
            // 
            // 
            this.agtb.CustomButton.Image = null;
            this.agtb.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.agtb.CustomButton.Name = "";
            this.agtb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.agtb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.agtb.CustomButton.TabIndex = 1;
            this.agtb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.agtb.CustomButton.UseSelectable = true;
            this.agtb.CustomButton.Visible = false;
            this.agtb.Lines = new string[0];
            this.agtb.Location = new System.Drawing.Point(227, 204);
            this.agtb.MaxLength = 32767;
            this.agtb.Name = "agtb";
            this.agtb.PasswordChar = '\0';
            this.agtb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.agtb.SelectedText = "";
            this.agtb.SelectionLength = 0;
            this.agtb.SelectionStart = 0;
            this.agtb.ShortcutsEnabled = true;
            this.agtb.Size = new System.Drawing.Size(316, 23);
            this.agtb.TabIndex = 45;
            this.agtb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.agtb.UseSelectable = true;
            this.agtb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.agtb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // namtb
            // 
            // 
            // 
            // 
            this.namtb.CustomButton.Image = null;
            this.namtb.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.namtb.CustomButton.Name = "";
            this.namtb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.namtb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.namtb.CustomButton.TabIndex = 1;
            this.namtb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.namtb.CustomButton.UseSelectable = true;
            this.namtb.CustomButton.Visible = false;
            this.namtb.Lines = new string[0];
            this.namtb.Location = new System.Drawing.Point(227, 161);
            this.namtb.MaxLength = 32767;
            this.namtb.Name = "namtb";
            this.namtb.PasswordChar = '\0';
            this.namtb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.namtb.SelectedText = "";
            this.namtb.SelectionLength = 0;
            this.namtb.SelectionStart = 0;
            this.namtb.ShortcutsEnabled = true;
            this.namtb.Size = new System.Drawing.Size(316, 23);
            this.namtb.TabIndex = 44;
            this.namtb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.namtb.UseSelectable = true;
            this.namtb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.namtb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // idtb
            // 
            // 
            // 
            // 
            this.idtb.CustomButton.Image = null;
            this.idtb.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.idtb.CustomButton.Name = "";
            this.idtb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idtb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idtb.CustomButton.TabIndex = 1;
            this.idtb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idtb.CustomButton.UseSelectable = true;
            this.idtb.CustomButton.Visible = false;
            this.idtb.Lines = new string[0];
            this.idtb.Location = new System.Drawing.Point(227, 116);
            this.idtb.MaxLength = 32767;
            this.idtb.Name = "idtb";
            this.idtb.PasswordChar = '\0';
            this.idtb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idtb.SelectedText = "";
            this.idtb.SelectionLength = 0;
            this.idtb.SelectionStart = 0;
            this.idtb.ShortcutsEnabled = true;
            this.idtb.Size = new System.Drawing.Size(316, 23);
            this.idtb.TabIndex = 43;
            this.idtb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.idtb.UseSelectable = true;
            this.idtb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idtb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(88, 416);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(45, 19);
            this.metroLabel7.TabIndex = 42;
            this.metroLabel7.Text = "Salary";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(88, 369);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(46, 19);
            this.metroLabel6.TabIndex = 41;
            this.metroLabel6.Text = "Phone";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(88, 309);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 40;
            this.metroLabel5.Text = "Address";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(88, 255);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 19);
            this.metroLabel4.TabIndex = 39;
            this.metroLabel4.Text = "Gender";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(88, 208);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(33, 19);
            this.metroLabel3.TabIndex = 38;
            this.metroLabel3.Text = "Age";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(88, 165);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Name";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(88, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "ID";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UserControlAdminAddDoctor
            // 
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.adtb);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.satb);
            this.Controls.Add(this.phtb);
            this.Controls.Add(this.gntb);
            this.Controls.Add(this.agtb);
            this.Controls.Add(this.namtb);
            this.Controls.Add(this.idtb);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UserControlAdminAddDoctor";
            this.Text = "Add Doctor";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.UserControlAdminAddDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void UserControlAdminAddDoctor_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            UserControlAdminAddDoctor.ActiveForm.Hide();
            new AdminDoctor().Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(idtb.Text.ToString()=="" && namtb.Text.ToString() == "" && agtb.Text.ToString() == "" && gntb.Text.ToString() == ""&& adtb.Text.ToString() == ""&& phtb.Text.ToString() == ""&& satb.Text.ToString() == "")

            {
                MetroMessageBox.Show(this, "Failed.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    hmssDataContext dbcon = new hmssDataContext();
                    Doctor doc = new Doctor();

                    doc.DoctorID = idtb.Text.ToString();
                    doc.DoctorName = namtb.Text.ToString();
                    doc.DoctorAge = agtb.Text.ToString();
                    doc.DoctorGender = gntb.Text.ToString();
                    doc.DoctorAddress = adtb.Text.ToString();
                    doc.DoctorPhone = phtb.Text.ToString();
                    doc.DoctorSalary = satb.Text.ToString();

                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Username already exist.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    idtb.Clear();
                    namtb.Clear();
                    agtb.Clear();
                    gntb.Clear();
                    adtb.Clear();
                    phtb.Clear();
                    satb.Clear();
                }

            }


        }
    }
}

namespace HospitalManagementSystem
{
    partial class adminAccountantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminAccountantForm));
            this.metroTextButtonAdminAccountantList = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonAdminAddAccountant = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.back = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTextButtonAdminAccountantList
            // 
            this.metroTextButtonAdminAccountantList.Image = null;
            this.metroTextButtonAdminAccountantList.Location = new System.Drawing.Point(145, 90);
            this.metroTextButtonAdminAccountantList.Name = "metroTextButtonAdminAccountantList";
            this.metroTextButtonAdminAccountantList.Size = new System.Drawing.Size(280, 50);
            this.metroTextButtonAdminAccountantList.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextButtonAdminAccountantList.TabIndex = 4;
            this.metroTextButtonAdminAccountantList.Text = "Accountant List";
            this.metroTextButtonAdminAccountantList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextButtonAdminAccountantList.UseSelectable = true;
            this.metroTextButtonAdminAccountantList.UseVisualStyleBackColor = true;
            this.metroTextButtonAdminAccountantList.Click += new System.EventHandler(this.metroTextButtonAdminAccountantList_Click);
            // 
            // metroTextButtonAdminAddAccountant
            // 
            this.metroTextButtonAdminAddAccountant.Image = null;
            this.metroTextButtonAdminAddAccountant.Location = new System.Drawing.Point(426, 90);
            this.metroTextButtonAdminAddAccountant.Name = "metroTextButtonAdminAddAccountant";
            this.metroTextButtonAdminAddAccountant.Size = new System.Drawing.Size(280, 50);
            this.metroTextButtonAdminAddAccountant.TabIndex = 5;
            this.metroTextButtonAdminAddAccountant.Text = "Add Accountant";
            this.metroTextButtonAdminAddAccountant.UseSelectable = true;
            this.metroTextButtonAdminAddAccountant.UseVisualStyleBackColor = true;
            this.metroTextButtonAdminAddAccountant.Click += new System.EventHandler(this.metroTextButtonAdminAddAccountant_Click);
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
            // adminAccountantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.back);
            this.Controls.Add(this.metroTextButtonAdminAccountantList);
            this.Controls.Add(this.metroTextButtonAdminAddAccountant);
            this.Name = "adminAccountantForm";
            this.Text = "Accountant";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.adminAccountantForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAdminAccountantList;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAdminAddAccountant;
        private MetroFramework.Controls.MetroTile back;
    }
}
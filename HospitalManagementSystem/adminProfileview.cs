using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class adminProfileview : MetroFramework.Forms.MetroForm
    {
        public static string holdID = "";
        public static string holdProfile = "";
        public adminProfileview()
        {
            InitializeComponent();
            holdID = LoginForm.LoginID;
            holdProfile = LoginForm.LoginProfile;
        }

        private void adminProfileview_Load(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            hmssDataContext dbcon = new hmssDataContext();
            Admin pro1 = new Admin();

            pro1 = dbcon.Admins.SingleOrDefault(x => x.LoginID == holdID);
            if (pro1.LoginID == holdID && holdProfile == "ADMIN")
            {


                if (pro1 != null)
                {
                    
                    metroTextBox1.Text = pro1.AdminName;
                    metroTextBox2.Text = "N/A";
                    metroTextBox3.Text = "N/A";
                    metroTextBox4.Text = "N/A";
                    metroTextBox5.Text = pro1.AdminPhone;
                    metroTextBox6.Text = "N/A";

                }
                else
                {
                    MessageBox.Show(" NULL ADMIN");
                    MetroMessageBox.Show(this, "Incorrect Data.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }



        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            adminProfileview.ActiveForm.Hide();
            new AdminForm().Show();
        }
    }
}

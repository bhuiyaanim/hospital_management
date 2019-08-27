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
    public partial class accountantProfileShow : MetroFramework.Forms.MetroForm
    {
        public static string holdID = "";
        public static string holdProfile = "";
        public accountantProfileShow()
        {
            InitializeComponent();
            holdID = LoginForm.LoginID;
            holdProfile = LoginForm.LoginProfile;

        }

        private void accountantProfileShow_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            hmssDataContext dbcon = new hmssDataContext();
            Accountant pro6 = new Accountant();
            pro6 = dbcon.Accountants.SingleOrDefault(x => x.LoginID == holdID);
            if (pro6.AccountantID == holdID && holdProfile == "ACCOUNTANT")

            {
                MessageBox.Show(holdProfile);

                if (pro6 != null)
                {
                    metroTextBox1.Text = pro6.AccountantName;
                    metroTextBox2.Text = pro6.AccountantAge;
                    metroTextBox3.Text = pro6.AccountantGender;
                    metroTextBox4.Text = pro6.AccountantAddress;
                    metroTextBox5.Text = pro6.AccountantPhone;
                    metroTextBox6.Text = pro6.AccountantEmail;

                }
                else
                {
                    MetroMessageBox.Show(this, "Incorrect Data.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

            }


        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            accountantProfileShow.ActiveForm.Hide();
            new Accountantform().Show();
        
        }
    }
}

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
    public partial class DoctorProfileView : MetroFramework.Forms.MetroForm
    {
        public static string holdID = "";
        public static string holdProfile = "";
        public DoctorProfileView()
        {
            InitializeComponent();
            holdID = LoginForm.LoginID;
            holdProfile = LoginForm.LoginProfile;
        }

        private void DoctorProfileView_Load(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            hmssDataContext dbcon = new hmssDataContext();

            Doctor pro5 = new Doctor();
            pro5 = dbcon.Doctors.SingleOrDefault(x => x.LoginID == holdID);

            MessageBox.Show(holdID, holdProfile);

            if (pro5.LoginID == holdID && holdProfile == "DOCTOR")

            {


                if (pro5 != null)
                {
                    metroTextBox1.Text = pro5.DoctorName;
                    metroTextBox2.Text = pro5.DoctorAge;
                    metroTextBox3.Text = pro5.DoctorGender;
                    metroTextBox4.Text = pro5.DoctorAddress;
                    metroTextBox5.Text = pro5.DoctorPhone;
                    metroTextBox6.Text = pro5.DoctorEmail;

                }
                else
                {
                    MetroMessageBox.Show(this, "Incorrect Data.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            DoctorProfileView.ActiveForm.Hide();
            new DoctorForm().Show();
        }
    }
}

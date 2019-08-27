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
    public partial class PatientProfileView : MetroFramework.Forms.MetroForm
    {
        public static string holdID = "";
        public static string holdProfile = "";
        public PatientProfileView()
        {
            InitializeComponent();
            holdID = LoginForm.LoginID;
            holdProfile = LoginForm.LoginProfile;
        }

        private void PatientProfileView_Load(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            hmssDataContext dbcon = new hmssDataContext();

            Patient pro2 = new Patient();
            pro2 = dbcon.Patients.SingleOrDefault(x => x.LoginID == holdID);

            if (pro2.LoginID == holdID && holdProfile == "PATIENT")
            {
                if (pro2 != null)
                {
                    MessageBox.Show("NOT NULL");
                    metroTextBox1.Text = pro2.PatientName;
                    metroTextBox2.Text = pro2.PatientAge;
                    metroTextBox3.Text = pro2.PatientGender;
                    metroTextBox4.Text = pro2.PatientAddress;
                    metroTextBox5.Text = pro2.PatientPhone;
                    metroTextBox6.Text = "N/A";

                }
                else
                {
                    MessageBox.Show("NULL");
                    MetroMessageBox.Show(this, "NULL DATABASE.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }
    }
}
    
    


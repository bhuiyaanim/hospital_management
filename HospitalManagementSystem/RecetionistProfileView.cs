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
    public partial class RecetionistProfileView : MetroFramework.Forms.MetroForm
    {
        public static string holdID = "";
        public static string holdProfile = "";
        public RecetionistProfileView()
        {
            InitializeComponent();
            holdID = LoginForm.LoginID;
            holdProfile = LoginForm.LoginProfile;
        }

        private void RecetionistProfileView_Load(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            hmssDataContext dbcon = new hmssDataContext();

            Receptionist pro3 = new Receptionist();
            pro3 = dbcon.Receptionists.SingleOrDefault(x => x.LoginID == holdID);

            MessageBox.Show(holdID, holdProfile);

            if (pro3.LoginID == holdID && holdProfile == "RECEPTIONIST")
            {


                if (pro3 != null)
                {
                    metroTextBox1.Text = pro3.ReceptionistName;
                    metroTextBox2.Text = pro3.ReceptionistAge;
                    metroTextBox3.Text = pro3.ReceptionistGender;
                    metroTextBox4.Text = pro3.ReceptionistAddress;
                    metroTextBox5.Text = pro3.ReceptionistPhone;
                    metroTextBox6.Text = pro3.ReceptionistEmail;

                }
                else
                {
                    MetroMessageBox.Show(this, "Incorrect Data.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            RecetionistProfileView.ActiveForm.Hide();
            new Receptionistfrom().Show();

        }
    }
}

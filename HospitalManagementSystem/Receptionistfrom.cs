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
    public partial class Receptionistfrom : MetroFramework.Forms.MetroForm
    {
        public Receptionistfrom()
        {
            InitializeComponent();
        }

        private void Receptionistfrom_Load(object sender, EventArgs e)
        {

        }

        private void Patient_Click(object sender, EventArgs e)
        {
            Receptionistfrom.ActiveForm.Hide();
            new RecepPatientList().Show();
        }

        private void Patient1_Click(object sender, EventArgs e)
        {
            Receptionistfrom.ActiveForm.Hide();
            new RecepPatientList().Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Receptionistfrom.ActiveForm.Hide();
            new RecepDoctorList().Show();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            Receptionistfrom.ActiveForm.Hide();
            new RecepRoomList().Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Receptionistfrom.ActiveForm.Hide();
            new RecetionistProfileView().Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Receptionistfrom.ActiveForm.Hide();
            new LoginForm().Show();
        }

        private void Profile1_Click(object sender, EventArgs e)
        {
            Receptionistfrom.ActiveForm.Hide();
            new RecetionistProfileView().Show();
        }
    }
}

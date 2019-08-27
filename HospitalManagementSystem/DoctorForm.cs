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
    public partial class DoctorForm : MetroFramework.Forms.MetroForm
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }

        private void Patient_Click(object sender, EventArgs e)
        {
            DoctorForm.ActiveForm.Hide();
            new doctorPatient().Show();
        }

        private void Patient1_Click(object sender, EventArgs e)
        {
            DoctorForm.ActiveForm.Hide();
            new doctorPatient().Show();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            DoctorForm.ActiveForm.Hide();
            new DoctorForm().Show();

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DoctorForm.ActiveForm.Hide();
            new LoginForm().Show();
        }

        private void Profile1_Click(object sender, EventArgs e)
        {
            DoctorForm.ActiveForm.Hide();
            new DoctorProfileView().Show();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            DoctorForm.ActiveForm.Hide();
            new DoctorProfileView().Show();
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

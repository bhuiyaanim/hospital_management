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
    public partial class PatientForm : MetroFramework.Forms.MetroForm
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            PatientForm.ActiveForm.Hide();
            new AdminDoctorList().Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            PatientForm.ActiveForm.Hide();
            new PatientForm().Show();
        }

        private void dateTile_Click(object sender, EventArgs e)
        {
            PatientForm.ActiveForm.Hide();
            new PatientForm().Show();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            PatientForm.ActiveForm.Hide();
            new LoginForm().Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            PatientForm.ActiveForm.Hide();
            new PatientProfileView().Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            PatientForm.ActiveForm.Hide();
            new PatientProfileView().Show();
        }
    }
}

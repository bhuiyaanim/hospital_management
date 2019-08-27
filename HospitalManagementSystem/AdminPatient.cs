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
    public partial class AdminPatient : MetroFramework.Forms.MetroForm
    {
        public AdminPatient()
        {
            InitializeComponent();
        }

        private void AdminPatient_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            AdminPatient.ActiveForm.Hide();
            new AdminForm().Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            AdminPatient.ActiveForm.Hide();
            new AdminPatientList().Show();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            AdminPatient.ActiveForm.Hide();
            new UserControlAdminAddPatient().Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            AdminPatient.ActiveForm.Hide();
            new AdminForm().Show();
        }
    }
}

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
    public partial class AdminDoctor : MetroFramework.Forms.MetroForm
    {
        public AdminDoctor()
        {
            InitializeComponent();
        }

        private void AdminDoctor_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            AdminDoctor.ActiveForm.Hide();
            new AdminForm().Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            AdminDoctor.ActiveForm.Hide();
            new AdminDoctorList().Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            AdminDoctor.ActiveForm.Hide();
            new UserControlAdminAddDoctor().Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            AdminDoctor.ActiveForm.Hide();
            new AdminForm().Show();
        }
    }
}

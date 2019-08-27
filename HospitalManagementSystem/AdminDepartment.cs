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
    public partial class AdminDepartment : MetroFramework.Forms.MetroForm
    {
        public AdminDepartment()
        {
            InitializeComponent();
        }

        private void AdminDepartment_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            AdminDepartment.ActiveForm.Hide();
            new LoginForm().Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            AdminDepartment.ActiveForm.Hide();
            new AdminDepartmentaList().Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            AdminDepartment.ActiveForm.Hide();
            new UserControlAdminAddDepartment().Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            AdminDepartment.ActiveForm.Hide();
            new AdminForm().Show();
        }
    }
}

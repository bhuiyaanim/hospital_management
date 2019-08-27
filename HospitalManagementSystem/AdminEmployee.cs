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
    public partial class AdminEmployee : MetroFramework.Forms.MetroForm
    {
        public AdminEmployee()
        {
            InitializeComponent();
        }

        private void AdminEmployee_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            AdminEmployee.ActiveForm.Hide();
            new AdminForm().Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            AdminEmployee.ActiveForm.Hide();
            new AdminEmployeeList().Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            AdminEmployee.ActiveForm.Hide();
            new UserControlAdminAddEmployee().Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            AdminEmployee.ActiveForm.Hide();
            new AdminForm().Show();
        }
    }
}

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
    public partial class AdminEmployeeList : MetroFramework.Forms.MetroForm
    {
        public AdminEmployeeList()
        {
            InitializeComponent();
        }

        private void AdminEmployeeList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSSDataSet3.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hMSSDataSet3.Employee);

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTileAdminDoctor_Click(object sender, EventArgs e)
        {
            AdminEmployeeList.ActiveForm.Hide();
            new AdminEmployee().Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            AdminEmployeeList.ActiveForm.Hide();
            new AdminEmployee().Show();
        }
    }
}

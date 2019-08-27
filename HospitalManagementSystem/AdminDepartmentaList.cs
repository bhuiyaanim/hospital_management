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
    public partial class AdminDepartmentaList : MetroFramework.Forms.MetroForm
    {
        public AdminDepartmentaList()
        {
            InitializeComponent();
        }

        private void AdminDepartmentaList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSSDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hMSSDataSet.Department);

        }

        private void metroTileAdminTime_Click(object sender, EventArgs e)
        {
            AdminDepartmentaList.ActiveForm.Hide();
            new AdminForm().Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            AdminDepartmentaList.ActiveForm.Hide();
            new AdminDepartment().Show();
        }
    }
}

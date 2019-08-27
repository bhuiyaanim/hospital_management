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
    public partial class AdminAccountList : MetroFramework.Forms.MetroForm
    {
        public AdminAccountList()
        {
            InitializeComponent();
        }

        private void AdminAccountList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSSDataSet4.Accountant' table. You can move, or remove it, as needed.
            this.accountantTableAdapter.Fill(this.hMSSDataSet4.Accountant);

        }

        private void back_Click(object sender, EventArgs e)
        {
            AdminAccountList.ActiveForm.Hide();
            new adminAccountantForm().Show();
        }
    }
}

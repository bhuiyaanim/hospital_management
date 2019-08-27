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
    public partial class adminAccountantForm : MetroFramework.Forms.MetroForm
    {
        public adminAccountantForm()
        {
            InitializeComponent();
        }

        private void adminAccountantForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            adminAccountantForm.ActiveForm.Hide();
            new AdminForm().Show();
        }

        private void metroTextButtonAdminAccountantList_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTextButtonAdminAddAccountant_Click(object sender, EventArgs e)
        {
            adminAccountantForm.ActiveForm.Hide();
            new UserControlAdminAddAccountant().Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            adminAccountantForm.ActiveForm.Hide();
            new AdminAccountList().Show();
        }
    }
}

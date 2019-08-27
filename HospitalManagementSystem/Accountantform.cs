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
    public partial class Accountantform : MetroFramework.Forms.MetroForm
    {
        public Accountantform()
        {
            InitializeComponent();
        }

        private void Accountantform_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Accountantform.ActiveForm.Hide();
            new Accountantform().Show();
        }

        private void invoice_Click(object sender, EventArgs e)
        {
            Accountantform.ActiveForm.Hide();
            new accountantInvoiceForm().Show();

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Accountantform.ActiveForm.Hide();
            new LoginForm().Show();
        }

        private void Salary_Click(object sender, EventArgs e)
        {
            Accountantform.ActiveForm.Hide();
            new accountantSalaryForm().Show();
        }

        private void Salary1_Click(object sender, EventArgs e)
        {
            Accountantform.ActiveForm.Hide();
            new accountantSalaryForm().Show();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            Accountantform.ActiveForm.Hide();
            new accountantProfileShow().Show();
        }

        private void Profile2_Click(object sender, EventArgs e)
        {
            Accountantform.ActiveForm.Hide();
            new accountantProfileShow().Show();
        }
    }
}

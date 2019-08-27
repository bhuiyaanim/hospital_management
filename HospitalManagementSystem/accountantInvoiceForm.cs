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
    public partial class accountantInvoiceForm : MetroFramework.Forms.MetroForm
    {
        public accountantInvoiceForm()
        {
            InitializeComponent();
        }

        private void accountantInvoiceForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTileAdminEmployee_Click(object sender, EventArgs e)
        {
            accountantInvoiceForm.ActiveForm.Hide();
            new accountantCreateInvociceForm().Show();
        }

        private void metroTileAdminPatient_Click(object sender, EventArgs e)
        {
            accountantInvoiceForm.ActiveForm.Hide();
            new accountantInvoiceList().Show();
        }

        private void metroTileAdminProfile_Click(object sender, EventArgs e)
        {
            accountantInvoiceForm.ActiveForm.Hide();
            new Accountantform().Show();
        }
    }
}

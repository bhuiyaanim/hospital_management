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
    public partial class accountantInvoiceList : MetroFramework.Forms.MetroForm
    {
        public accountantInvoiceList()
        {
            InitializeComponent();
        }

        private void accountantInvoiceList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSSDataSet8.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.hMSSDataSet8.Invoice);

        }

        private void metroTileAdminEmployee_Click(object sender, EventArgs e)
        {
            accountantInvoiceList.ActiveForm.Hide();
            new accountantInvoiceForm().Show();
        }
    }
}

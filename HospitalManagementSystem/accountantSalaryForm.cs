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
    public partial class accountantSalaryForm : MetroFramework.Forms.MetroForm
    {
        public accountantSalaryForm()
        {
            InitializeComponent();
        }

        private void accountantSalaryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSSDataSet9.Salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.hMSSDataSet9.Salary);

        }
    }
}

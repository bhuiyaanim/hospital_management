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
    public partial class RecepPatientList : MetroFramework.Forms.MetroForm
    {
        public RecepPatientList()
        {
            InitializeComponent();
        }

        private void RecepPatientList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSSDataSet11.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hMSSDataSet11.Patient);

        }

        private void metroTileAdminEmployee_Click(object sender, EventArgs e)
        {
            RecepPatientList.ActiveForm.Hide();
            new Receptionistfrom().Show();
        }
    }
}

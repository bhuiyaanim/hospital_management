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
    public partial class doctorPatient : MetroFramework.Forms.MetroForm

    {
        public doctorPatient()
        {
            InitializeComponent();
        }

        private void doctorPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSSDataSet7.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hMSSDataSet7.Patient);

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            doctorPatient.ActiveForm.Hide();
            new DoctorForm().Show();
        }
    }
}

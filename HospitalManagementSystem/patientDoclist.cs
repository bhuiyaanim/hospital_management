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
    public partial class patientDoclist : MetroFramework.Forms.MetroForm
    {
        public patientDoclist()
        {
            InitializeComponent();
        }

        private void patientDoclist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSSDataSet13.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hMSSDataSet13.Doctor);

        }

        private void metroTileAdminPatient_Click(object sender, EventArgs e)
        {
            patientDoclist.ActiveForm.Hide();
            new PatientForm().Show();
        }
    }
}

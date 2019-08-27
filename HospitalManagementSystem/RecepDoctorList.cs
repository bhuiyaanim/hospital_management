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
    public partial class RecepDoctorList : MetroFramework.Forms.MetroForm
    {
        public RecepDoctorList()
        {
            InitializeComponent();
        }

        private void RecepDoctorList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSSDataSet10.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hMSSDataSet10.Doctor);

        }

        private void metroTileAdminDepartment_Click(object sender, EventArgs e)
        {
            RecepDoctorList.ActiveForm.Hide();
            new Receptionistfrom().Show();
        }
    }
}

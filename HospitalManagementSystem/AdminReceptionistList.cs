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
    public partial class AdminReceptionistList : MetroFramework.Forms.MetroForm
    {
        public AdminReceptionistList()
        {
            InitializeComponent();
        }

        private void AdminReceptionistList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSSDataSet5.Receptionist' table. You can move, or remove it, as needed.
            this.receptionistTableAdapter.Fill(this.hMSSDataSet5.Receptionist);

        }

        private void metroTileAdminPatient_Click(object sender, EventArgs e)
        {
            AdminReceptionistList.ActiveForm.Hide();
            new adminRececptionistForm().Show();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void back_Click(object sender, EventArgs e)
        {
            AdminReceptionistList.ActiveForm.Hide();
            new adminRececptionistForm().Show();
        }
    }
}

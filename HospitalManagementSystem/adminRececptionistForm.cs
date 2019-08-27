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
    public partial class adminRececptionistForm : MetroFramework.Forms.MetroForm
    {
        public adminRececptionistForm()
        {
            InitializeComponent();
        }

        private void adminRececptionistForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTileAdminAccountant_Click(object sender, EventArgs e)
        {
            adminRececptionistForm.ActiveForm.Hide();
            new AdminForm().Show();
        }

        private void metroTileAdminDate_Click(object sender, EventArgs e)
        {
            adminRececptionistForm.ActiveForm.Hide();
            new AdminReceptionistList().Show();
        }

        private void metroTileAdminProfile_Click(object sender, EventArgs e)
        {
            adminRececptionistForm.ActiveForm.Hide();
            new UserControlAdminAddReceptionist().Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            adminRececptionistForm.ActiveForm.Hide();
            new AdminForm().Show();
        }
    }
}

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
    public partial class AdminRoom : MetroFramework.Forms.MetroForm
    {
        public AdminRoom()
        {
            InitializeComponent();
        }

        private void AdminRoom_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            AdminRoom.ActiveForm.Hide();
            new AdminForm().Show();

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            AdminRoom.ActiveForm.Hide();
            new AdminRoomList().Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            AdminRoom.ActiveForm.Hide();
            new UserControlAdminAddRoom().Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            AdminRoom.ActiveForm.Hide();
            new AdminForm().Show();
        }
    }
}

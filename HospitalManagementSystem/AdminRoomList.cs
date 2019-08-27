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
    public partial class AdminRoomList : MetroFramework.Forms.MetroForm
    {
        public AdminRoomList()
        {
            InitializeComponent();
        }

        private void AdminRoomList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSSDataSet6.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hMSSDataSet6.Room);

        }

        private void back_Click(object sender, EventArgs e)
        {
            AdminRoomList.ActiveForm.Hide();
            new AdminRoom().Show();
        }
    }
}

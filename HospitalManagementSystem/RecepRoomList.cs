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
    public partial class RecepRoomList : MetroFramework.Forms.MetroForm
    {
        public RecepRoomList()
        {
            InitializeComponent();
        }

        private void RecepRoomList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSSDataSet12.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hMSSDataSet12.Room);

        }

        private void metroTileAdminLogOut_Click(object sender, EventArgs e)
        {
            RecepRoomList.ActiveForm.Hide();
            new Receptionistfrom().Show();
        }
    }
}

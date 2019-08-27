using MetroFramework;
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
    public partial class UserControlAdminAddRoom : MetroFramework.Forms.MetroForm
    {
        public UserControlAdminAddRoom()
        {
            InitializeComponent();
        }

        private void UserControlAdminAddRoom_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            metroTextBox1.Clear();
            metroTextBox2.Clear();
            metroTextBox3.Clear();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.ToString() == "" && metroTextBox2.Text.ToString() == "" && metroTextBox3.Text.ToString() == "")
            {
                MetroMessageBox.Show(this, "Some Thing Went wrong", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    hmssDataContext dbcon = new hmssDataContext();
                        Room rm = new Room();
                    rm.RoomNo = metroTextBox1.Text.ToString();
                    rm.R_DateOfAdmition = metroTextBox2.Text.ToString();
                    rm.R_DateOfRelease = metroTextBox3.Text.ToString();
                    MetroMessageBox.Show(this, "Succesfully Saved.", "Congratulation!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Clear();
                }

                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Username already exist.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    Clear();
                    
                }
            }

        }
    }
}

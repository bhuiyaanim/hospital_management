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
    public partial class UserControlAdminAddDepartment : MetroFramework.Forms.MetroForm
    {
        public UserControlAdminAddDepartment()
        {
            InitializeComponent();
        }

        private void UserControlAdminAddDepartment_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroButton1.Text.ToString() == "" && metroTextBox5.Text.ToString() == "")
            {
                MetroMessageBox.Show(this, "Failed", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    MetroMessageBox.Show(this,metroButton1.Text.ToString());
                    hmssDataContext dbcon = new hmssDataContext();
                    Department dp = new Department();
                    dp.DepartmentName = metroTextBox1.Text.ToString();
                    dp.DepartmentDescription = metroTextBox5.Text.ToString();
                    MetroMessageBox.Show(this, "Succesfully Saved.", "Congratulation!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Username already exist.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    metroTextBox1.Clear();
                    metroTextBox5.Clear();
                }
            }
        }


        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            UserControlAdminAddDepartment.ActiveForm.Hide();
            new AdminDepartment().Show();
        }
    }
}

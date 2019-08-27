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
    public partial class UserControlAdminAddAccountant : MetroFramework.Forms.MetroForm
    {
        public UserControlAdminAddAccountant()
        {
            InitializeComponent();
        }

        private void UserControlAdminAddAccountant_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

       

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            metroTextBox1.Clear();
            metroTextBox2.Clear();
            metroTextBox3.Clear();
            metroTextBox4.Clear();
            metroTextBox5.Clear();
            metroTextBox6.Clear();
            metroTextBox7.Clear();
            metroTextBox8.Clear();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            string aID = metroTextBox1.Text;
            string aNam = metroTextBox2.Text;
            string aAdd = metroTextBox3.Text;
            string aPho = metroTextBox4.Text;
            string aSal = metroTextBox5.Text;
            string aAge = metroTextBox6.Text;
            string aGen = metroTextBox7.Text;
            string aEm = metroTextBox8.Text;

            if (aID.ToString() == "" && aNam.ToString() == "" && aAdd == "" && aPho == "" & aSal == "" && aAge == "" && aGen.ToString() == "" && aEm.ToString() == "")
            {
                MetroMessageBox.Show(this, "Something went wrong", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    hmssDataContext dbcon = new hmssDataContext();
                    Accountant ac = new Accountant();

                    ac.AccountantID = aID.ToString();
                    ac.AccountantName = aNam.ToString();
                    ac.AccountantAddress = aAdd.ToString();
                    ac.AccountantPhone = aPho.ToString();
                    ac.AccountantSalary = aSal.ToString();
                    ac.AccountantAge = aAge.ToString();
                    ac.AccountantGender = aGen.ToString();
                    ac.AccountantEmail = aEm.ToString();
                    MetroMessageBox.Show(this, "Succesfully Saved.", "Congratulation!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    clear();



                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Username already exist.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    clear();
                }

            }


        }
    }
}

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
    public partial class ProfileForm : MetroFramework.Forms.MetroForm
    {
        public static string holdID = "";
        public static string holdProfile = "";
        public ProfileForm()
        {
            InitializeComponent();
            holdID = LoginForm.LoginID;
            holdProfile = LoginForm.LoginProfile;
            
            
        }

       
        
       

        

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        
        
        
        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {

           
           
                hmssDataContext dbcon = new hmssDataContext();
                
                Admin pro1 = new Admin();
                Receptionist pro3 = new Receptionist();
                Employee pro4 = new Employee();
                Doctor pro5 = new Doctor();
               

                pro1 = dbcon.Admins.SingleOrDefault(x => x.LoginID == holdID);
                
                
                pro5 = dbcon.Doctors.SingleOrDefault(x => x.LoginID == holdID);
                pro3 = dbcon.Receptionists.SingleOrDefault(x => x.LoginID == holdID);
                pro4 = dbcon.Employees.SingleOrDefault(x => x.LoginID == holdID);


                MessageBox.Show(holdID,holdProfile);


                if (pro1.LoginID == holdID && holdProfile == "ADMIN")
                {
                   

                    if (pro1 != null)
                    {
                        MessageBox.Show("NOT NULL ADMIN");
                        metroTextBox1.Text = pro1.AdminName;
                        metroTextBox2.Text = "N/A";
                        metroTextBox3.Text = "N/A";
                        metroTextBox4.Text = "N/A";
                        metroTextBox5.Text = pro1.AdminPhone;
                        metroTextBox6.Text = "N/A";

                    }
                    else
                    {
                        MessageBox.Show(" NULL ADMIN");
                        MetroMessageBox.Show(this, "Incorrect Data.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    }

                    Patient pro2 = new Patient();
                    pro2 = dbcon.Patients.SingleOrDefault(x => x.LoginID == holdID);

                if (pro2.LoginID == holdID && holdProfile == "PATIENT")
                     {
                       if (pro2 != null)
                       {
                            MessageBox.Show("NOT NULL");
                        metroTextBox1.Text = pro2.PatientName;
                        metroTextBox2.Text = pro2.PatientAge;
                        metroTextBox3.Text = pro2.PatientGender;
                        metroTextBox4.Text = pro2.PatientAddress;
                        metroTextBox5.Text = pro2.PatientPhone;
                        metroTextBox6.Text = "N/A";

                         }
                         else
                    {
                        MessageBox.Show("NULL");
                        MetroMessageBox.Show(this, "NULL DATABASE.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    }

            Accountant pro6 = new Accountant();
            pro6 = dbcon.Accountants.SingleOrDefault(x => x.LoginID == holdID);


                if (pro6.AccountantID == holdID && holdProfile == "ACCOUNTANT")

                     {
                     MessageBox.Show(holdProfile);

                     if (pro6 != null)
                    {
                        metroTextBox1.Text = pro6.AccountantName;
                        metroTextBox2.Text = pro6.AccountantAge;
                        metroTextBox3.Text = pro6.AccountantGender;
                        metroTextBox4.Text = pro6.AccountantAddress;
                        metroTextBox5.Text = pro6.AccountantPhone;
                        metroTextBox6.Text = pro6.AccountantEmail;

                        }
                        else
                        {
                        MetroMessageBox.Show(this, "Incorrect Data.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        }

                         }


               if (pro5.LoginID == holdID && holdProfile == "DOCTOR")

                         {


                    if (pro5 != null)
                    {
                        metroTextBox1.Text = pro5.DoctorName;
                        metroTextBox2.Text = pro5.DoctorAge;
                        metroTextBox3.Text = pro5.DoctorGender;
                        metroTextBox4.Text = pro5.DoctorAddress;
                        metroTextBox5.Text = pro5.DoctorPhone;
                        metroTextBox6.Text = pro5.DoctorEmail;

                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Incorrect Data.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }


                    }

               else  if (pro3.LoginID == holdID && holdProfile == "RECEPTIONIST")
                      {


                    if (pro3 != null)
                    {
                        metroTextBox1.Text = pro3.ReceptionistName;
                        metroTextBox2.Text = pro3.ReceptionistAge;
                        metroTextBox3.Text = pro3.ReceptionistGender;
                        metroTextBox4.Text = pro3.ReceptionistAddress;
                        metroTextBox5.Text = pro3.ReceptionistPhone;
                        metroTextBox6.Text = pro3.ReceptionistEmail;

                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Incorrect Data.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }

                    }
                else if (pro4.LoginID == holdID && holdProfile == "Employee")
                       {


                    if (pro4 != null)
                    {
                        metroTextBox1.Text = pro4.EmployeeName;
                        metroTextBox2.Text = pro4.EmployeeAge;
                        metroTextBox3.Text = pro4.EmployeeGender;
                        metroTextBox4.Text = pro4.EmployeeAddress;
                        metroTextBox5.Text = pro4.EmployeePhone;
                        metroTextBox6.Text = pro4.EmployeeEmail;

                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Incorrect Data.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
        
        }

        private void metroTextBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

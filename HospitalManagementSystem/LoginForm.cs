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
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        Timer t = new Timer();
        public static string LoginID = "";
        public static string LoginProfile = "";
       
       
        public LoginForm()
        {
            InitializeComponent();
            passwordtf.PasswordChar = '●';
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            t.Interval = 1000; // in ms
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
        }



        private void TimmerUpdate(object sender, EventArgs e)
        {
            t.Interval = 1000; // in ms
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
            t.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("HH:mm:ss");
            string date = DateTime.Now.ToString("dd:MM:yyyy");
            timedesign.Text = clock;
            Datedesign.Text = date;



        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {

            
        }



        private void usernametf_Click(object sender, EventArgs e)
        {

        }

        private void passwordtf_Click(object sender, EventArgs e)
        {

        }
        private void login_Click(object sender, EventArgs e)
        {
            login.Hide();
            timedesign.Hide();
            Datedesign.Hide();
        }







        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                hmssDataContext logindbcon = new hmssDataContext();
                Login log = new Login();
                log = logindbcon.Logins.SingleOrDefault(x => x.UserName == usernametf.Text && x.UserPassword == passwordtf.Text);
                

                if (log.UserProfile == "ADMIN" && usernametf.Text.ToString() == log.UserName && passwordtf.Text.ToString() == log.UserPassword)
                {

                   LoginForm.ActiveForm.Hide();
                   new AdminForm().Show();
                    LoginID = log.UserID;
                    LoginProfile = log.UserProfile;


                }

                if (log.UserProfile == "DOCTOR" && usernametf.Text.ToString() == log.UserName && passwordtf.Text.ToString() == log.UserPassword)
                {

                    LoginForm.ActiveForm.Hide();
                    new DoctorForm().Show();
                    LoginID = log.UserID;
                    LoginProfile = log.UserProfile;


                }


                if (log.UserProfile == "ACCOUNTANT" && usernametf.Text.ToString() == log.UserName && passwordtf.Text.ToString() == log.UserPassword)
                {
                    LoginForm.ActiveForm.Hide();
                    new Accountantform().Show();
                    LoginID = log.UserID;
                    LoginProfile = log.UserProfile;


                }
                

                if (log.UserProfile == "PATIENT" && usernametf.Text.ToString() == log.UserName && passwordtf.Text.ToString() == log.UserPassword)
                {

                    LoginForm.ActiveForm.Hide();
                    new PatientForm().Show();
                    LoginID = log.UserID;
                    LoginProfile = log.UserProfile;

                }
                
                

                if (log.UserProfile == "RECEPTIONEST" && usernametf.Text.ToString() == log.UserName && passwordtf.Text.ToString() == log.UserPassword)
                {

                    LoginForm.ActiveForm.Hide();
                    new Receptionistfrom().Show();
                    LoginID = log.UserID;
                    LoginProfile = log.UserProfile;


                }
                

                if (log.UserProfile == "EMPLOYEE" && usernametf.Text.ToString() == log.UserName && passwordtf.Text.ToString() == log.UserPassword)
                {

                    LoginForm.ActiveForm.Hide();
                    

                }
               


            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Incorrect Username or Password", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                usernametf.Clear();
                passwordtf.Clear();
            }

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
        



        private void timedesign_Click(object sender, EventArgs e)
        {

        }

        private void Datedesign_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }
    }
}

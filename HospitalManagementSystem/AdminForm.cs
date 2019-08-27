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
    public partial class AdminForm : MetroFramework.Forms.MetroForm
    {
        Timer t = new Timer();
        public AdminForm()
        {
            InitializeComponent();
                                 
        }

       

        
       

        private void AdminForm_Load(object sender, EventArgs e)
        {
            t.Interval = 1000; // in ms
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
        }

        private void metroTextButtonDepartment_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new AdminDepartment().Show();
        }

        private void metroTileAdminDepartment_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new AdminDepartment().Show();
        }

        private void metroTextButtonDoctor_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new AdminDoctor().Show();
        }

        private void metroTileAdminDoctor_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new AdminDoctor().Show();
        }

        private void metroTextButtonPatient_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new AdminPatient().Show();
        }

        private void metroTileAdminPatient_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new AdminPatient().Show();
        }

        private void metroTextButtonEmployee_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new AdminEmployee().Show();
        }

        private void metroTileAdminEmployee_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new AdminEmployee().Show();
        }

        private void metroTextButtonAccountant_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new Accountantform().Show();
        }

        private void metroTileAdminAccountant_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new Accountantform().Show();
        }

        private void metroTextButtonReceptionist_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new Receptionistfrom().Show();

        }

        private void metroTileAdminReceptionist_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new Receptionistfrom().Show();
        }

        private void metroTextButtonAdminRoom_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new AdminRoom().Show();
        }

        private void metroTileAdminRoom_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new AdminRoom().Show();
        }

        public void metroTextButtonProfile_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new adminProfileview().Show();
            
            
        }

        private void metroTileAdminProfile_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new adminProfileview().Show();
        }

        private void metroTileAdminLogOut_Click(object sender, EventArgs e)
        {
            AdminForm.ActiveForm.Hide();
            new LoginForm().Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("HH:mm:ss");
            string date = DateTime.Now.ToString("dd:MM:yyyy");
            metroTileAdminTime.Text = clock;
            metroTileAdminDate.Text = date;
        }


        private void metroTileAdminTime_Click(object sender, EventArgs e)
        {

        }

        private void metroTileAdminDate_Click(object sender, EventArgs e)
        {

        }
       

    }
}

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
    public partial class accountantCreateInvociceForm : MetroFramework.Forms.MetroForm
    {
        public accountantCreateInvociceForm()
        {
            InitializeComponent();
        }

        private void accountantCreateInvociceForm_Load(object sender, EventArgs e)
        {

        }

        private void idtb_Click(object sender, EventArgs e)
        {

        }

        private void datetb_Click(object sender, EventArgs e)
        {

        }

        private void namtb_Click(object sender, EventArgs e)
        {

        }

        private void doctb_Click(object sender, EventArgs e)
        {

        }

        private void rmtb_Click(object sender, EventArgs e)
        {

        }

        private void adtb_Click(object sender, EventArgs e)
        {

        }

        private void reltb_Click(object sender, EventArgs e)
        {

        }

        private void achgtb_Click(object sender, EventArgs e)
        {

        }

        private void schgtb_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox15_Click(object sender, EventArgs e)
        {

        }

        private void rmchgperdaytb_Click(object sender, EventArgs e)
        {

        }

        private void rmfordaytb_Click(object sender, EventArgs e)
        {

        }

        private void vattb_Click(object sender, EventArgs e)
        {

        }

        private void distb_Click(object sender, EventArgs e)
        {

        }

        private void biltb_Click(object sender, EventArgs e)
        {

        }

        private void logtb_Click(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            idtb.Clear();
           datetb.Clear();
            namtb.Clear();
            doctb.Clear();
            rmtb.Clear();
            adtb.Clear();
            reltb.Clear();
            achgtb.Clear();
            schgtb.Clear();
            metroTextBox15.Clear();
            rmchgperdaytb.Clear();
            rmfordaytb.Clear();
            vattb.Clear();
            distb.Clear();
            biltb.Clear();
            logtb.Clear();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (idtb.Text.ToString()==""&&datetb.Text.ToString()==""&&namtb.Text.ToString() == ""&&doctb.Text.ToString() == ""&&rmtb.Text.ToString() == ""&& adtb.Text.ToString() == ""&& reltb.Text.ToString() == ""&&achgtb.Text.ToString() == ""&&schgtb.Text.ToString() == ""&& metroTextBox15.Text.ToString() == "" &&rmchgperdaytb.Text.ToString() == "" &&rmfordaytb.Text.ToString() == "" &&vattb.Text.ToString() == "" &&distb.Text.ToString() == "" && biltb.Text.ToString() == "" && logtb.Text.ToString() == "" )
            {
                MetroMessageBox.Show(this, "Insert All!", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                Clear();
            }
            else
            {
               
                try
                {
                    hmssDataContext dbcon = new hmssDataContext();
                    Invoice inv = new Invoice();

                    inv.InvoiceID = idtb.Text.ToString();
                    inv.InvoiceDate = datetb.Text.ToString();
                    inv.I_PatientName = namtb.Text.ToString();
                    inv.I_DoctorName = doctb.Text.ToString();
                    inv.I_RoomNo = rmtb.Text.ToString();
                    inv.I_DateOfAdmition = adtb.Text.ToString();
                    inv.I_DateOfRelease = reltb.Text.ToString();
                    inv.I_AdmissionCharge = achgtb.Text.ToString();
                    inv.I_ServiceCharge = schgtb.Text.ToString();
                    inv.I_DoctorFees = metroTextBox15.Text.ToString();
                    inv.I_RoomChargePerDay = rmchgperdaytb.Text.ToString();
                    inv.I_RoomForDays = rmfordaytb.Text.ToString();
                    inv.I_Vat = vattb.Text.ToString();
                    inv.I_Discount = distb.Text.ToString();
                    inv.I_TotalBill = biltb.Text.ToString();
                    inv.LoginID = logtb.Text.ToString();
                    MetroMessageBox.Show(this, "Succesfully Saved.", "Congratulation!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Clear();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Failed.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    Clear();

                }


            }


        }

        private void pdf_Click(object sender, EventArgs e)
        {

        }
    }
}

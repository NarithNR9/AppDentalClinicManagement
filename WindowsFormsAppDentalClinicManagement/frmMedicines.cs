using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDentalClinicManagement
{
    public partial class frmMedicines : Form
    {
        public frmMedicines()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmDatabase frm = new frmDatabase();
            frm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmDatabase frm = new frmDatabase();
            frm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmAppointment frm = new frmAppointment();
            frm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmAppointment frm = new frmAppointment();
            frm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmPatients frm = new frmPatients();
            frm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmPatients frm = new frmPatients();
            frm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmTreatment frm = new frmTreatment();
            frm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmTreatment frm = new frmTreatment();
            frm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmLogIn frm = new frmLogIn();
            frm.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmLogIn frm = new frmLogIn();
            frm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The record has been added");
        }
    }
}

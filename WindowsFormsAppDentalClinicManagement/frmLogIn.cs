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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            frmAppointment frm = new frmAppointment();
            frm.Show();
            this.Hide();
        }

        private void lblResetPassword_Click(object sender, EventArgs e)
        {
            frmResetPassword frm = new frmResetPassword();
            frm.Show();
        }
    }
}

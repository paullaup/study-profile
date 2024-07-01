using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcurementSystem
{
    public partial class LoginUI : Form
    {

        private LoginControl loginControl;

        public LoginUI()
        {
            InitializeComponent();
            loginControl = new LoginControl(this);
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblAlert.Text = "";
            if (txtID.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                lblAlert.Text = "Please input staff ID and password";
                return;
            }
            if(loginControl.Login(txtID.Text, txtPassword.Text))
            {
                this.Hide();
            }
            else
            {
                lblAlert.Text = "Staff ID or Password wrong";
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            loginControl.startRegister();
        }

        private void cboPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cboPassword.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else 
                txtPassword.UseSystemPasswordChar = true;
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }

        private void btnFindPassword_Click(object sender, EventArgs e)
        {
            loginControl.startFindPassword();
        }
    }
}

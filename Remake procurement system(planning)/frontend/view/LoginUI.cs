using frontend.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontend.view
{
    public partial class LoginUI : Form
    {

        LoginControl loginControl;

        public LoginUI(object loginControl)
        {
            InitializeComponent();
            this.loginControl = (LoginControl)loginControl;
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string password = txtPassword.Text;
            loginControl.login(id, password);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        public void showErrorMsg()
        {
            MessageBox.Show("staffID or password incorrect");
        }
    }
}

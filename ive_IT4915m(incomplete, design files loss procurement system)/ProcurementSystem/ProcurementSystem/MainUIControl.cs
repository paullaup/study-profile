using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcurementSystem
{
    internal abstract class MainUIControl
    {

        protected Account account;
        protected LoginUI loginUI;
        protected Form applicationForm;     // Menu form

        public MainUIControl(Account account, LoginUI loginUI)
        {
            this.account = account;
            this.loginUI = loginUI; 
        }

        public void setApplicationForm(Form applicationForm)
        {
            this.applicationForm = applicationForm;
        }

        public void logout()
        {
            applicationForm.Close();
            loginUI.Show();
        }

        public Account GetAccount()
        {
            return account;
        }

        public Form getUI()
        {
            return applicationForm;
        }



    }
}

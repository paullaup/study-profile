using frontend.model;
using frontend.model.data;
using frontend.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontend.control
{
    internal class LoginControl 
    {

        public static LoginUI loginUI;
        private AccountApp api;
        public static Account account { get; set; }



        public LoginControl()
        {
            api = new AccountApp();
            LoginControl.loginUI = new LoginUI(this);
            Application.Run(loginUI);
        }

        public void login(string staffID, string password)
        {
            account = new Account(staffID, password);
            string[] accountData = api.getEmployeeData(LoginControl.account);
            if(accountData[0] == "unauthorized")
            {
                LoginControl.loginUI.showErrorMsg();
            }
            else
            {
                LoginControl.account.setStaffData(accountData[0], accountData[1], accountData[2]);
                LoginControl.account.setPermission(api.getPermissionName(LoginControl.account.getPosition()));
                new MainControl();
                LoginControl.loginUI.Hide();
            }
        }

    }
}

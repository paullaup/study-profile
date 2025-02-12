using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcurementSystem
{
    internal class RegisterControl 
    {

        private AccountAdapter account;
        private RegisterUI registerUI;
        private LoginUI loginUI;

        public RegisterControl(LoginUI loginUI)
        {
            account = new AccountAdapter();
            this.loginUI = loginUI;
            this.registerUI = new RegisterUI(this);
            registerUI.Show();
            loginUI.Hide();
        }

        public bool register(string ID, string password, string[] question, string[] answer)
        {
            string position = account.getPosition(ID);
            if (!(position.Equals("Restaurant Manager") || position.Equals("Purchase Manager")))
            {
                MessageBox.Show("position");
                return false;
            }
            account.addAccount(ID, password, question, answer);
            return true;
        }

        public string[] getQuestions()
        {
            return account.getQuestion();
        }

        public void end()
        {
            loginUI.Show();
            registerUI.Hide();
        }

    }
}

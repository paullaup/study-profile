using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ProcurementSystem
{
    internal class FindPasswordControl
    {

        private LoginUI loginUI;
        private AccountAdapter accountAdapter;
        private FindPasswordUI findPasswordUI;
        private string[] Questions;

        public FindPasswordControl(LoginUI loginUI)
        {
            this.loginUI = loginUI;
            this.accountAdapter = new AccountAdapter();
            this.findPasswordUI = new FindPasswordUI(this);
            loginUI.Hide();
            findPasswordUI.Show();
        }

        public void end()
        {
            loginUI.Show();
            findPasswordUI.Close();
        }

        public string[] getQuestion(string staffID)
        {
            if(!accountAdapter.checkAccount(staffID))
                return null;
            this.Questions = accountAdapter.getQuestion(staffID);
            return Questions;   
        }

        public bool answerQuestion(string staffID, TextBox[] answers) 
        {
            bool isCorrect = true;
            for(int i = 0; i < answers.Length; i++)
            {
                isCorrect = (isCorrect && accountAdapter.verifySecurityAnswer(staffID, accountAdapter.getQuestionID(this.Questions[i]), answers[i].Text.ToString()));
            }
            if(isCorrect)
            {
                MessageBox.Show("Answer correct, your password is " + accountAdapter.getPassword(staffID));
                end();
            }
            return isCorrect;
        }


    }
}

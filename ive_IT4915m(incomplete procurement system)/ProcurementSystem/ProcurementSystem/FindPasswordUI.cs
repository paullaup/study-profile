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
    public partial class FindPasswordUI : Form
    {

        private FindPasswordControl findPasswordControl;
        private Label[] questions;
        private TextBox[] answers;

        public FindPasswordUI(object findPasswordControl)
        {
            InitializeComponent();
            this.findPasswordControl = (FindPasswordControl)findPasswordControl;
            this.questions = new Label[3];
            this.questions[0] = lblQuestion1;
            this.questions[1] = lblQuestion2;
            this.questions[2] = lblQuestion3;
            this.answers = new TextBox[3];
            this.answers[0] = txtQuestion1;
            this.answers[1] = txtQuestion2;
            this.answers[2] = txtQuestion3;
        }

        private void GetPasswordUI_Load(object sender, EventArgs e)
        {
            btnFindPassword.Enabled = false;

        }

        private void btnEnterID_Click(object sender, EventArgs e)
        {
            lblAlert.Text = "";
            if(txtID.Text.Length==0)
            {
                lblAlert.Text = "Please enter your staffID";
                return;
            }
            string[] questions = findPasswordControl.getQuestion(txtID.Text.ToString());
            if(questions == null)
            {
                lblAlert.Text = "Invaild staff ID";
                return;
            }
            for(int i = 0; i<this.questions.Length; i++)
            {
                this.questions[i].Text += questions[i];
            }
            btnEnterID.Enabled = false;
            txtID.Enabled = false;
            btnFindPassword.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            findPasswordControl.end();
        }

        private void btnFindPassword_Click(object sender, EventArgs e)
        {
            if(txtQuestion1.Text.Length == 0 || txtQuestion2.Text.Length == 0 || txtQuestion3.Text.Length == 0)
            {
                lblAlert.Text = "Please answer the security question";
                return; 
            }
            if (!this.findPasswordControl.answerQuestion(txtID.Text.ToString(), this.answers))
            {
                lblAlert.Text = "Answer not correct";
                return;
            }

        }
    }
}

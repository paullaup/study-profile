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
    public partial class RegisterUI : Form
    {

        private RegisterControl registerControl;
        private string[] selectedItems;
        private string[] answers;

        public RegisterUI(object registerControl)
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtPassword2.UseSystemPasswordChar = true;
            this.registerControl = (RegisterControl) registerControl;
            loadComboBox();
            answers = new string[3];
            selectedItems = new string[3];
            for (int i = 0; i < selectedItems.Length; i++)
                selectedItems[i] = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            registerControl.end();
        }

        private void cboPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cboPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword2.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword2.UseSystemPasswordChar = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblIDAlert.Text = "";
            lblAlertPassword.Text = "";
            lblAlertQuestion.Text = "";
            if (txtID.Text.Length == 0)
            {
                lblIDAlert.Text = "Please input a Staff ID";
                return;
            }
            if (txtPassword.Text.Length == 0 || txtPassword2.Text.Length == 0)
            {
                lblAlertPassword.Text = "Please fill in the password boxes";
                return;
            }
            if(!txtPassword.Text.Equals(txtPassword2.Text))
            {
                lblAlertPassword.Text = "Those two password should be the same";
                return;
            }
            if(txtPassword.Text.Length > 20)
            {
                lblAlertPassword.Text = "Password should not be more than 20 digit";
                return;
            }
            if (cbbQuestion1.SelectedItem == null || cbbQuestion2.SelectedItem == null || cbbQuestion3.SelectedItem == null || txtQuestion1.Text.Length == 0 || txtQuestion2.Text.Length == 0 || txtQuestion3.Text.Length == 0)
            {
                lblAlertQuestion.Text = "Please answer all the security question";
                return;
            }
            if(txtQuestion1.Text.Length>30 || txtQuestion2.Text.Length>30 || txtQuestion3.Text.Length>30)
            {
                lblAlertQuestion.Text = "Answer should not be more than 30 digit";
            }
            answers[0] = txtQuestion1.Text;
            answers[1] = txtQuestion2.Text;
            answers[2] = txtQuestion3.Text;
            if(registerControl.register(txtID.Text, txtPassword.Text, selectedItems, answers))
            {
                MessageBox.Show("true");
                registerControl.end();
            }
            else
            {
                MessageBox.Show("false");
            }
        }

        private void RegisterUI_Load(object sender, EventArgs e)
        {

        }

        public void loadComboBox()
        {
            string[] questions = registerControl.getQuestions();
            cbbQuestion1.Items.AddRange(questions);
            cbbQuestion2.Items.AddRange(questions);
            cbbQuestion3.Items.AddRange(questions);
        }

        private void questionCbbChange(object sender, EventArgs e)
        {
            cbbQuestion3.Items.Remove(null);
            Object selectedItem = ((ComboBox)sender).SelectedItem;
            if(sender == cbbQuestion1)
            {
                AddAndRemoveItem(cbbQuestion2, selectedItems[0], selectedItem);
                AddAndRemoveItem(cbbQuestion3, selectedItems[0], selectedItem);
                selectedItems[0] = selectedItem.ToString();
            }
            else if(sender == cbbQuestion2)
            {
                AddAndRemoveItem(cbbQuestion1, selectedItems[1], selectedItem);
                AddAndRemoveItem(cbbQuestion3, selectedItems[1], selectedItem);
                selectedItems[1] = selectedItem.ToString();
            }
            else if (sender == cbbQuestion3)
            {
                AddAndRemoveItem(cbbQuestion1, selectedItems[2], selectedItem);
                AddAndRemoveItem(cbbQuestion2, selectedItems[2], selectedItem);
                selectedItems[2] = selectedItem.ToString();
            }
        }

        private void AddAndRemoveItem(ComboBox cbb, object addItem, object removeItem)
        {
            if (addItem != null)
                cbb.Items.Add(addItem);
            cbb.Items.Remove(removeItem);
        }


    }
}

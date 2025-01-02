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
    public partial class AccountManageUI : Form
    {

        private AccountManageControl accountManageControl;

        public AccountManageUI()
        {
            InitializeComponent();
        }

        public void setControl(object accountManageControl)
        {
            this.accountManageControl = (AccountManageControl)accountManageControl;
        }

        private void AccountManageUI_Load(object sender, EventArgs e)
        {

        }
    }
}

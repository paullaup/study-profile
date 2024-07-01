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
    public partial class PurchaseManagerUI : Form
    {

        private PurchaseManagerControl mainUIControl;


        public PurchaseManagerUI(object mainUIControl)
        {
            InitializeComponent();
            this.mainUIControl = (PurchaseManagerControl)mainUIControl;
            this.Show();
        }

        private void PurchaseManagerUI_Load(object sender, EventArgs e)
        {

        }

        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            mainUIControl.logout();
        }

        private void viewRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainUIControl.startMapRequest();
        }

        private void makeSecheduleReleaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainUIControl.makeScheduleRelease();
        }
    }
}

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
    public partial class RestaurantManagerUI : Form
    {

        private RestaurantManagerControl mainUIControl;

        public RestaurantManagerUI(object UIControl)
        {
            InitializeComponent();
            mainUIControl = (RestaurantManagerControl) UIControl;
            this.Show();
        }


        private void RestaurantManager_Load(object sender, EventArgs e)
        {
            
        }



        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainUIControl.logout();
        }

        private void myRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainUIControl.startMakeEditRequest();
        }
    }
}

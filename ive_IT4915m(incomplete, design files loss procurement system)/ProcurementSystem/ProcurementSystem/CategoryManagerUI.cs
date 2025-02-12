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
    public partial class CategoryManagerUI : Form
    {

        private MainUIControl mainUIControl;

        public CategoryManagerUI(object uiControl)
        {
            InitializeComponent();
            mainUIControl = (CategoryManagerControl)uiControl;
            this.Show();
        }

        private void CategoryManagerUI_Load(object sender, EventArgs e)
        {

        }
    }
}

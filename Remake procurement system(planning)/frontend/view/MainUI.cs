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
    public partial class MainUI : Form
    {

        private MainControl mainControl;

        public MainUI(object mainControl)
        {
            InitializeComponent();
            this.mainControl = (MainControl)mainControl;
        }

        public void addFunction(string[] functions)
        {
            foreach (string function in functions)
            {
                menuStrip.Items.Add(function);
            }
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string functionName = e.ClickedItem.Text;
            mainControl.startFunctionByName(functionName);
        }
    }
}

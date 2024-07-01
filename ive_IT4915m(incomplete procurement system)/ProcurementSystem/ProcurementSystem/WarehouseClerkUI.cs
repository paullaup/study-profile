using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcurementSystem
{
    public partial class WarehouseClerkUI : Form
    {

        private WarehouseClerkControl mainUIControl;

        public WarehouseClerkUI(object mainUIControl)
        {
            InitializeComponent();
            this.mainUIControl = (WarehouseClerkControl)mainUIControl;
            this.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainUIControl.logout();
        }

        private void WarehouseClerkUI_Load(object sender, EventArgs e)
        {

        }

        private void receiveDespatchInstructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainUIControl.receiveDespatchInstruction();
        }

        private void updateDeliveryNoteStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainUIControl.updateDeliveryNoteStatus();
        }
    }
}

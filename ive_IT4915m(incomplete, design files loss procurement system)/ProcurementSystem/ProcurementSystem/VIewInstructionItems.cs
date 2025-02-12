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
    public partial class VIewInstructionItems : Form
    {

        private DespatchInstructionLineAdapter despatchInstructionLineAdapter;

        public VIewInstructionItems(int instructionID)
        {
            InitializeComponent();
            despatchInstructionLineAdapter = new DespatchInstructionLineAdapter();
            dgvInstructionItems.DataSource = despatchInstructionLineAdapter.getInstructionItems(instructionID);
            dgvInstructionItems.ReadOnly = true;
            dgvInstructionItems.AllowUserToAddRows = false;
            this.Show();
        }

        private void VIewInstructionItems_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

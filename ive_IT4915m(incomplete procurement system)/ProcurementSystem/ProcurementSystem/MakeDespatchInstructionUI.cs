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
    public partial class MakeDespatchInstructionUI : Form
    {

        private MakeDestpatchInstructionControl makeDespatchInstructionControl;
        private DataTable warehouseInventory;
        private BindingSource warehouseInventoryBingindSource;
        private DataTable addedItems;


        public MakeDespatchInstructionUI(object makeDespatchInstructionControl, string requestID, string remark, DataTable warehouseInventory, DataTable addedItems)
        {
            InitializeComponent();
            this.makeDespatchInstructionControl = (MakeDestpatchInstructionControl)makeDespatchInstructionControl;
            txtRequestID.Text = requestID;
            this.addedItems = addedItems;
            richTxtRequestRemark.Text = remark;
            this.warehouseInventory = warehouseInventory;
            warehouseInventoryBingindSource = new BindingSource();
            warehouseInventoryBingindSource.DataSource = warehouseInventory;
            dgvWarehouseInventory.DataSource = warehouseInventoryBingindSource;
            txtItemID.DataBindings.Add("text", warehouseInventoryBingindSource, "itemID");
            dgvSelectedInventory.DataSource = addedItems;
        }

        private void MakeDespatchInstructionUI_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            makeDespatchInstructionControl.cancel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow[] foundRows = warehouseInventory.Select("itemID= '" + txtItemID.Text + "'");
            if (foundRows.Length == 0)
            {
                MessageBox.Show("error");
                return;
            }
            if(!int.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("error2");
                return;
            }
            DataRow row = addedItems.NewRow();
            row["itemID"] = txtItemID.Text;
            row["quantity"] = int.Parse(txtQuantity.Text);
            row["remark"] = richTxtInstructionRemark.Text;
            addedItems.Rows.Add(row);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DataRow[] foundRows = addedItems.Select("itemID= '" + txtItemID.Text + "'");
            if(MessageBox.Show("Are you sure you want to delete and item with itemID " + txtItemID.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0;  i < foundRows.Length; i++)
                {
                    addedItems.Rows.Remove(foundRows[i]);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DespatchInstruction instruction = new DespatchInstruction("Waiting to be receive");
            DespatchInstructionLine[] despatchInstructionLines = new DespatchInstructionLine[addedItems.Rows.Count];
            for(int i = 0;i < despatchInstructionLines.Length;i++)
            {
                DataRow row = addedItems.Rows[i];
                despatchInstructionLines[i] = new DespatchInstructionLine(instruction.getPONumber(), row["itemID"].ToString(), int.Parse(row["quantity"].ToString()), row["remark"].ToString());
            }
            makeDespatchInstructionControl.submit(instruction, despatchInstructionLines);

        }

        private void btnSearchRequestItem_Click(object sender, EventArgs e)
        {
            makeDespatchInstructionControl.viewRequestItem(txtRequestID.Text);
        }
    }
}

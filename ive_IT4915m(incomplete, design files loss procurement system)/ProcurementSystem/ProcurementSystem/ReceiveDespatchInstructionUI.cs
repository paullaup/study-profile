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
    public partial class ReceiveDespatchInstructionUI : Form
    {

        private ReceiveDespatchInstructionControl receiveDespatchInstructionControl;
        DataTable instructionQueue;
        DataTable warehouseInventory;
        BindingSource instructionBindingSource;
        DataTable deliveryNotes;
        BindingSource deliveryNotesBindingSource;

        public ReceiveDespatchInstructionUI(object receiveDespatchInstructionControl, DataTable instructionQueue, DataTable warehouseInventory, DataTable deliveryNotes)
        {
            InitializeComponent();
            this.receiveDespatchInstructionControl = (ReceiveDespatchInstructionControl)receiveDespatchInstructionControl;
            this.instructionQueue = instructionQueue;
            this.warehouseInventory = warehouseInventory;
            this.deliveryNotes = deliveryNotes;
            instructionBindingSource = new BindingSource();
            deliveryNotesBindingSource = new BindingSource();
            instructionBindingSource.DataSource = instructionQueue;
            dgvInstuctionQueue.DataSource = instructionBindingSource;
            deliveryNotesBindingSource.DataSource = deliveryNotes;
            dgvDeliveryNote.DataSource = deliveryNotesBindingSource;
            txtInstructionID.DataBindings.Add("text", instructionBindingSource, "instructionID");
            txtDeliveryNoteNumber.DataBindings.Add("text", deliveryNotesBindingSource, "deliveryNoteNumber");
            richTxtNoteRemark.DataBindings.Add("text", deliveryNotesBindingSource, "remark");
            richTxtAddress.DataBindings.Add("text", instructionBindingSource, "Address");
            dgvInstuctionQueue.ReadOnly = true;
            dgvInstuctionQueue.AllowUserToAddRows = false;
            dgvInventory.DataSource = warehouseInventory;
            dgvInventory.ReadOnly = true;
            dgvInventory.AllowUserToAddRows = false;
            dgvDeliveryNote.ReadOnly = true;
            dgvDeliveryNote.AllowUserToAddRows = false;

        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            if(instructionQueue.Select("instructionID = '" + txtInstructionID.Text + "'").Length > 0)
                receiveDespatchInstructionControl.receiveDespatchInstruction(txtInstructionID.Text, richTxtNoteRemark.Text, richTxtAddress.Text, richTxtOtherShipmentInfo.Text);
        }

        private void ReceiveDespatchInstructionUI_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void btnViewDespatchInstructionItem_Click(object sender, EventArgs e)
        {
            receiveDespatchInstructionControl.viewInstructionItems(txtInstructionID.Text);
        }

        private void btnViewDeliveryNote_Click(object sender, EventArgs e)
        {
            receiveDespatchInstructionControl.viewDeliveryNoteLine(txtDeliveryNoteNumber.Text);
            
        }

        private void btnMapInstruction_Click(object sender, EventArgs e)
        {
            receiveDespatchInstructionControl.receiveDespatchInstruction(txtInstructionID.Text, txtDeliveryNoteNumber.Text);
        }
    }
}

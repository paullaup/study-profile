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
    public partial class ViewDeliveryNoteLine : Form
    {

        private DeliveryNoteLineAdapter noteAdapter;
        DataTable deliveryNote;
        BindingSource bindingSource;


        public ViewDeliveryNoteLine(int deliveryNoteNumber)
        {
            InitializeComponent();
            noteAdapter = new DeliveryNoteLineAdapter();
            deliveryNote = noteAdapter.getDeliveryNoteLineDT(deliveryNoteNumber);
            bindingSource = new BindingSource();
            bindingSource.DataSource = deliveryNote;
            dataGridView1.DataSource = bindingSource;
            this.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewitem_Click(object sender, EventArgs e)
        {
            new VIewInstructionItems(int.Parse(deliveryNote.Rows[bindingSource.Position]["instructionID"].ToString()));
        }
    }
}

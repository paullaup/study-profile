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
    public partial class UpdateDeliveryNoteStatusUI : Form
    {

        private UpdateDeliveryNoteStatusControl updateDeliveryNoteStatusControl;

        private DataTable deliveryNote;
        private BindingSource bindingSource;



        public UpdateDeliveryNoteStatusUI(object updateDeliveryNoteStatusControl, DataTable deliveryNote)
        {
            InitializeComponent();
            this.updateDeliveryNoteStatusControl = (UpdateDeliveryNoteStatusControl)updateDeliveryNoteStatusControl;
            this.deliveryNote = deliveryNote;
            bindingSource = new BindingSource();
            bindingSource.DataSource = deliveryNote;
            dataGridView1.DataSource = deliveryNote;
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            updateDeliveryNoteStatusControl.deliver(int.Parse(deliveryNote.Rows[bindingSource.Position]["deliveryNoteNumber"].ToString()));
        }

        private void UpdateDeliveryNoteStatusUI_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void btnViewDeliveryNoteLine_Click(object sender, EventArgs e)
        {
            updateDeliveryNoteStatusControl.viewDeliveryNoteLine(int.Parse(deliveryNote.Rows[bindingSource.Position]["deliveryNoteNumber"].ToString()));
        }
    }
}

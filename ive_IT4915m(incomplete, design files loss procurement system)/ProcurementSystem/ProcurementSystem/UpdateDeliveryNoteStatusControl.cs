using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class UpdateDeliveryNoteStatusControl
    {

        private WarehouseClerkControl warehouseClerkControl;
        private UpdateDeliveryNoteStatusUI updateDeliveryNoteStatusUI;

        private DeliveryNoteAdapter deliveryNoteAdapter;


        public UpdateDeliveryNoteStatusControl(WarehouseClerkControl warehouseClerkControl)
        {
            this.warehouseClerkControl = warehouseClerkControl;
            deliveryNoteAdapter = new DeliveryNoteAdapter();
            updateDeliveryNoteStatusUI = new UpdateDeliveryNoteStatusUI(this, deliveryNoteAdapter.getDeliveryNoteDT(null, $"DeliveryNote.status = 'Waiting to deliver' and DeliveryNote.warehouseID = '{warehouseClerkControl.GetAccount().getDeptID()}'"));
            updateDeliveryNoteStatusUI.MdiParent = warehouseClerkControl.getUI();
            updateDeliveryNoteStatusUI.Show();
        }

        public void deliver(int deliveryNoteNumber)
        {
            deliveryNoteAdapter.modifyDeliveryNoteStatus(deliveryNoteNumber, "Delivered");
        }

        public void viewDeliveryNoteLine(int deliveryLineNumber)
        {
            new ViewDeliveryNoteLine(deliveryLineNumber);
        }

    }
}

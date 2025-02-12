using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace ProcurementSystem
{
    internal class ReceiveDespatchInstructionControl
    {

        private ReceiveDespatchInstructionUI receiveDespatchInstructionUI;
        private WarehouseClerkControl warehouseClerkControl;

        private DespatchInstructionAdapter despatchInstructionAdapter;
        private WarehouseInventoryAdapter inventoryAdapter;
        private DeliveryNoteAdapter deliveryNoteAdapter;
        private RequestAdapter requestAdapter;
        private RequestLineAdapter requestLineAdapter;
        private DeliveryNoteLineAdapter deliveryNoteLineAdapter;

        public ReceiveDespatchInstructionControl(WarehouseClerkControl warehouseClerkControl)
        {
            this.warehouseClerkControl = warehouseClerkControl;
            despatchInstructionAdapter = new DespatchInstructionAdapter();
            inventoryAdapter = new WarehouseInventoryAdapter();
            deliveryNoteAdapter = new DeliveryNoteAdapter();
            requestAdapter = new RequestAdapter();  
            requestLineAdapter = new RequestLineAdapter();
            deliveryNoteLineAdapter = new DeliveryNoteLineAdapter();
            DataTable instructionDT = despatchInstructionAdapter.getDespatchInstructionDT(null, " DespatchInstruction.status = 'Waiting to be receive'");
            DataTable inventoryDT = inventoryAdapter.getWarehouseInventory(null, $" warehouseID = '{warehouseClerkControl.GetAccount().getDeptID()}'");
            DataTable deliveryNoteDT = deliveryNoteAdapter.getDeliveryNoteDT(null, $" DeliveryNote.warehouseID = '{warehouseClerkControl.GetAccount().getDeptID()}'  and DeliveryNote.status = 'Waiting to deliver' ");
            receiveDespatchInstructionUI = new ReceiveDespatchInstructionUI(this, instructionDT, inventoryDT, deliveryNoteDT);
            receiveDespatchInstructionUI.MdiParent = warehouseClerkControl.getUI();
            receiveDespatchInstructionUI.Show();
        }

        public void receiveDespatchInstruction(string instructionID, string noteRemark, string shipAddress, string otherShipmentInformation)
        {
            DeliveryNote deliveryNote = new DeliveryNote(warehouseClerkControl.GetAccount().getDeptID(), "Waiting to deliver", noteRemark, shipAddress);
            if (deliveryNoteAdapter.addDeliveryNote(deliveryNote))
            {
                deliveryNoteLineAdapter.addDeliveryNoteLine(new DeliveryNoteLine(deliveryNote.GetDeliveryNoteNumber(), int.Parse(instructionID)));
                string requestID = requestAdapter.getRequestIDByRequestLine(int.Parse(instructionID), "Warehouse");
                requestLineAdapter.addDeliveryNote(requestID, instructionID, deliveryNote, otherShipmentInformation);
                despatchInstructionAdapter.modifyInstructionStatus(instructionID, "Received");
            }
            Logger.writeLog($" ID : {warehouseClerkControl.GetAccount().getID()} warehouse clerk receive despatch instruction with instruction number {instructionID} and map to new delivery note {deliveryNote.GetDeliveryNoteNumber()}");
        }

        public void receiveDespatchInstruction(string instructionID, string deliveryNoteNumber)
        {
            DeliveryNoteLine deliveryNoteLine = new DeliveryNoteLine(int.Parse(deliveryNoteNumber), int.Parse(instructionID));
            deliveryNoteLineAdapter.addDeliveryNoteLine(deliveryNoteLine);
            despatchInstructionAdapter.modifyInstructionStatus(instructionID, "Received");
            Logger.writeLog($" ID : {warehouseClerkControl.GetAccount().getID()} warehouse clerk receive despatch instruction with instruction number {instructionID} and map to delivery note {deliveryNoteNumber}");
        }

        public void viewInstructionItems(string instructionID)
        {
            if(int.TryParse(instructionID, out _))
                new VIewInstructionItems(int.Parse(instructionID));
        }

        public void viewDeliveryNoteLine(string noteNumber)
        {
            if(int.TryParse(noteNumber, out _))
                new ViewDeliveryNoteLine(int.Parse(noteNumber));
        }



    }
}

using System;

namespace ProcurementSystem
{
    internal class DeliveryNote
    {
        private int deliveryNoteNumber;
        private string warehouseID;
        private string status;
        private string remark;
        private string shipAddress;

        private DeliveryNoteAdapter noteAdapter;

        public DeliveryNote( string warehouseID, string status, string remark, string shipAddress)
        {
            this.warehouseID = warehouseID;
            this.status = status;
            this.remark = remark;
            noteAdapter = new DeliveryNoteAdapter();
            deliveryNoteNumber = noteAdapter.getLatestDeliveryNoteNumber() + 1;
            this.shipAddress = shipAddress;
        }

        public string GetShipAddress()
        {
            return shipAddress;
        }

        public void SetShipAddress( string shipAddress )
        {
            this.shipAddress = shipAddress;
        }

        public int GetDeliveryNoteNumber()
        {
            return deliveryNoteNumber;
        }

        public void SetDeliveryNoteNumber(int deliveryNoteNumber)
        {
            this.deliveryNoteNumber = deliveryNoteNumber;
        }

        public string GetWarehouseID()
        {
            return warehouseID;
        }

        public void SetWarehouseID(string warehouseID)
        {
            this.warehouseID = warehouseID;
        }

        public string GetStatus()
        {
            return status;
        }

        public void SetStatus(string status)
        {
            this.status = status;
        }

        public string GetRemark()
        {
            return remark;
        }

        public void SetRemark(string remark)
        {
            this.remark = remark;
        }
    }
}

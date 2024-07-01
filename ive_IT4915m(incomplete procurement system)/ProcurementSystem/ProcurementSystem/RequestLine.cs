using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class RequestLine
    {
        private int requestID;
        private PurchaseOrder purchaseOrder;
        private string deliveryNoteNumber;
        private string otherShipmentInformation;

        public RequestLine(int requestID, PurchaseOrder purchaseOrder, string otherShipmentInformation)
        {
            this.requestID = requestID;
            this.purchaseOrder = purchaseOrder;
            this.otherShipmentInformation = otherShipmentInformation;
        }

        public int GetRequestID()
        {
            return requestID;
        }

        public void SetRequestID(int requestID)
        {
            this.requestID = requestID;
        }

        public PurchaseOrder GetPurchaseOrder()
        {
            return purchaseOrder;
        }

        public void SetPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            this.purchaseOrder = purchaseOrder;
        }

        public string GetDeliveryNoteNumber()
        {
            return deliveryNoteNumber;
        }

        public void SetDeliveryNoteNumber(string deliveryNoteNumber)
        {
            this.deliveryNoteNumber = deliveryNoteNumber;
        }

        public string GetOtherShipmentInformation()
        {
            return otherShipmentInformation;
        }

        public void SetOtherShipmentInformation(string otherShipmentInformation)
        {
            this.otherShipmentInformation = otherShipmentInformation;
        }

 
    }
}

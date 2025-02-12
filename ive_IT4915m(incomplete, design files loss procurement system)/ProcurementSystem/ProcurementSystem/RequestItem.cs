using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class RequestItem
    {

        private int requestID;
        private string itemID;
        private int quantity;

        public RequestItem(int requestID, string itemID, int quantity)
        {
            this.requestID = requestID;
            this.itemID = itemID;
            this.quantity = quantity;
        }

        public int getRequestID() { return requestID; }
        public string getItemID() { return itemID;} 
        public int getQuantity() { return quantity;}
    }
}

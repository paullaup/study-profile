using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class Request
    {

        private int requestID;
        private string restaurantID;
        private string staffID;
        private DateTime createdDate;
        private string itemID;
        private int quantity;
        private DateTime expectedDeliveryDate;
        private string status;
        private string remark;
        private RequestAdapter requestAdapter;

        public Request(string restaurantID, string staffID, DateTime createdDate, string itemID, int quantity, DateTime expectedDeliveryDate, string status, string remark)
        {
            requestAdapter = new RequestAdapter();
            this.restaurantID = restaurantID;
            this.staffID = staffID;
            this.createdDate = createdDate;
            this.itemID = itemID;
            this.quantity = quantity;
            this.expectedDeliveryDate = expectedDeliveryDate;
            this.status = status;
            this.remark = remark;
            requestID = requestAdapter.getLatestRequestID() + 1;
        }

        public Request(int requestID, string restaurantID, string staffID, DateTime createdDate, string itemID, int quantity, DateTime expectedDeliveryDate, string status, string remark)
        {
            this.requestID = requestID;
            this.restaurantID = restaurantID;
            this.staffID = staffID;
            this.createdDate = createdDate;
            this.itemID = itemID;
            this.quantity = quantity;
            this.expectedDeliveryDate = expectedDeliveryDate;
            this.status = status;
            this.remark = remark;
        }

        public int getRequestID()
        {
            return requestID;
        }

        public string getRestaurantID()
        {
            return restaurantID;
        }

        public string getStaffID()
        {
            return staffID;
        }

        public DateTime getCreatedDate()
        {
            return createdDate;
        }

        public string getItemID()
        {
            return itemID;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public DateTime getExpectedDeliveryDate()
        {
            return expectedDeliveryDate;
        }

        public String getStatus()
        {
            return status;
        }

        public string getRemark()
        {
            return remark;
        }

    }
}

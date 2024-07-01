using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class DespatchInstructionLine
    {
        private int instructionID;
        private string itemID;
        private int quantity;
        private string remark;

        public DespatchInstructionLine(int instructionID, string itemID, int quantity, string remark)
        {
            this.instructionID = instructionID;
            this.itemID = itemID;
            this.quantity = quantity;
            this.remark = remark;
        }

        public int GetInstructionID()
        {
            return instructionID;
        }

        public void SetInstructionID(int value)
        {
            instructionID = value;
        }

        public string GetItemID()
        {
            return itemID;
        }

        public void SetItemID(string value)
        {
            itemID = value;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void SetQuantity(int value)
        {
            quantity = value;
        }

        public string GetRemark()
        {
            return remark;
        }

        public void SetRemark(string value)
        {
            remark = value;
        }
    }
}

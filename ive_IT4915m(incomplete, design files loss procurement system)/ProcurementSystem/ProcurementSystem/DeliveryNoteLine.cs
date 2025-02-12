using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class DeliveryNoteLine
    {
        private int deliveryNoteNumber;
        private int instructionID;

        public DeliveryNoteLine(int deliveryNoteNumber, int instructionID)
        {
            this.deliveryNoteNumber = deliveryNoteNumber;
            this.instructionID = instructionID;
        }

        public int GetDeliveryNoteNumber()
        {
            return deliveryNoteNumber;
        }

        public void SetDeliveryNoteNumber(int value)
        {
            deliveryNoteNumber = value;
        }

        public int GetInstructionID()
        {
            return instructionID;
        }

        public void SetInstructionID(int value)
        {
            instructionID = value;
        }
    }
}

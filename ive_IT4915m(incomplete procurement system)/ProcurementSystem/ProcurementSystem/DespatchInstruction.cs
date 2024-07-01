using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProcurementSystem
{
    internal class DespatchInstruction : PurchaseOrder
    {

        private int instructionID;
        private string status;

        private DespatchInstructionAdapter despatchInstructionAdapter;


        public DespatchInstruction(string status) : base()
        {
            this.status = status;
            despatchInstructionAdapter = new DespatchInstructionAdapter();
            instructionID = despatchInstructionAdapter.getLatestedInstructionID() + 1;
        }

        public override int getPONumber()
        {
            return instructionID;
        }

        public void setStatus(string status )
        {
            this.status=status;
        }

        public string getStatus()
        {
            return status;
        }


    }
}

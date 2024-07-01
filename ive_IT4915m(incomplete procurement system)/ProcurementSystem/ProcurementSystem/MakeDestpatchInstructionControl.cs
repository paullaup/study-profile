using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class MakeDestpatchInstructionControl
    {

        private string requestID;

        private PurchaseManagerControl purchaseManagerControl;
        private MakeDespatchInstructionUI makeDespatchInstructionUI;

        private RequestAdapter requestAdapter;
        private DespatchInstructionAdapter despatchInstructionAdapter;
        private RequestLineAdapter requestLineAdapter;
        private DespatchInstructionLineAdapter despatchInstructionLineAdapter;

        private ViewWarehouseInventoryControl viewWarehouseInventoryControl;
        private ViewRequestItemControl viewRequestItemControl;

        public MakeDestpatchInstructionControl(string requestID, PurchaseManagerControl purchaseManagerControl)
        {
            this.requestID = requestID;
            this.purchaseManagerControl = purchaseManagerControl;
            DataTable dt = new DataTable();
            dt.Columns.Add("itemID");
            dt.Columns.Add("quantity");
            dt.Columns.Add("remark");
            viewWarehouseInventoryControl = new ViewWarehouseInventoryControl();
            requestAdapter = new RequestAdapter();
            makeDespatchInstructionUI = new MakeDespatchInstructionUI(this, requestID, requestAdapter.getRemark(requestID), viewWarehouseInventoryControl.getWarehouseInventoryDT(), dt);
            makeDespatchInstructionUI.MdiParent = purchaseManagerControl.getUI();
            makeDespatchInstructionUI.Show();
            requestAdapter.modifyRequestStatus(requestID, "Request mapping");
            Logger.writeLog(" ID : " + purchaseManagerControl.GetAccount().getID() + "purchase manager start to map request with requestID : " + requestID);
            despatchInstructionAdapter = new DespatchInstructionAdapter();
            requestLineAdapter = new RequestLineAdapter();
            despatchInstructionLineAdapter = new DespatchInstructionLineAdapter();
        }

        public void submit(DespatchInstruction despatchInstruction, DespatchInstructionLine[] despatchInstructionLines)
        {
            if (despatchInstructionAdapter.addDespatchInstruction(despatchInstruction))
            {
                for (int i = 0; i < despatchInstructionLines.Length; i++)
                {
                    despatchInstructionLineAdapter.addDespatchInstructionLine(despatchInstructionLines[i]);
                }
                Logger.writeLog(" ID : " + purchaseManagerControl.GetAccount().getID() + ", purchase manager make a Despatch instruction with instruction number : " + despatchInstruction.getPONumber());
                requestLineAdapter.addRequestLine(new RequestLine(int.Parse(requestID), despatchInstruction, ""));
                requestAdapter.mapRequest(requestID, "Warehouse");
                requestAdapter.modifyRequestStatus(requestID, "Request mapped");
                Logger.writeLog(" ID : " + purchaseManagerControl.GetAccount().getID() + ", purchase manager make a request line with requestID : " + requestID + " PONumber : " + despatchInstruction.getPONumber());
                Logger.writeLog(" ID : " + purchaseManagerControl.GetAccount().getID() + "purchase manager submit to map request with requestID : " + requestID);
            }
               
        }

        public void cancel()
        {
            requestAdapter.modifyRequestStatus(requestID, "Waiting for mapping");
            Logger.writeLog(" ID : " + purchaseManagerControl.GetAccount().getID() + "purchase manager submit to map request with requestID : " + requestID);
        }

        public void viewRequestItem(string requestID)
        {
            new ViewRequestItemControl(requestID);
        }

    }
}

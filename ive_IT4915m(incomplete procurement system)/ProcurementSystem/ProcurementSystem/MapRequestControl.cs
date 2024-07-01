using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProcurementSystem
{
    internal class MapRequestControl
    {

        private MapRequestUI mapRequestUI;
        private PurchaseManagerControl purchaseManagerControl;

        private ViewRequestItemControl viewRequestItemControl;
        private ViewRequestControl viewRequestControl;
        private ViewBPAControl viewBPAControl;
        private ViewWarehouseInventoryControl viewWarehouseInventoryControl;
        private ViewCPAControl viewCPAControl;
        private ViewPPOControl viewPPOControl;
        private ViewBPAItemsControl viewBPAItemsControl;
        private ViewPPOItemsControl viewPPOItemsControl;

        private RequestAdapter requestAdapter;

        public MapRequestControl(PurchaseManagerControl purchaseManagerControl)
        {
            this.purchaseManagerControl = purchaseManagerControl;
            viewRequestControl = new ViewRequestControl();
            viewBPAControl = new ViewBPAControl();
            viewWarehouseInventoryControl = new ViewWarehouseInventoryControl();
            viewCPAControl = new ViewCPAControl();
            viewPPOControl = new ViewPPOControl();
            requestAdapter = new RequestAdapter();

            DataTable requestdt = viewRequestControl.getRequestDT("RequestQueue", "status = 'waiting for mapping'");
            DataTable warehousedt = getWarehouseInventory(null);

            this.mapRequestUI = new MapRequestUI(this, requestdt, warehousedt);
            mapRequestUI.MdiParent = purchaseManagerControl.getUI();
            mapRequestUI.Show();
        }

        public DataTable getWarehouseInventory(string condition)
        {
            return viewWarehouseInventoryControl.getWarehouseInventoryDT();
        }

        public DataTable getBPA(string condition)
        {
            return viewBPAControl.getBPADT("BPA", condition);
        }

        public DataTable getCPA(string condition)
        {
            return viewCPAControl.getCPADT("CPA", condition);
        }

        public DataTable getPPO(string condition)
        {
            return viewPPOControl.getPPODT("PPO", condition);
        }

        public void startViewRequestItem(DataRow dr)
        {
            viewRequestItemControl = new ViewRequestItemControl(dr["requestID"].ToString());
        }

        public void startViewBPAItems(DataRow dr)
        {
            viewBPAItemsControl = new ViewBPAItemsControl(dr["BPAID"].ToString());
        }

        public void startViewPPOItems(DataRow dr)
        {
            viewPPOItemsControl = new ViewPPOItemsControl(dr["PPOID"].ToString());
        }

        public void startMakeBlanketRelease(string requestID)
        {
            string status = requestAdapter.getRequestStatus(requestID);
            if (!status.Equals("Waiting for mapping") && !status.Equals("Request mapped"))
            {
                return;
            }
            new MakeBlanketReleaseControl(requestID, purchaseManagerControl);
            requestAdapter.modifyRequestStatus(requestID, "Request Mapping");
        }

        public void MakeDespatchInstruction(string requestID)
        {
            string status = requestAdapter.getRequestStatus(requestID);
            if (!status.Equals("Waiting for mapping") && !status.Equals("Request mapped"))
            {
                return;
            }
            new MakeDestpatchInstructionControl(requestID, purchaseManagerControl);
            requestAdapter.modifyRequestStatus(requestID, "Request Mapping");
        }

        public void mapToContract(string  requestID)
        {
            string status = requestAdapter.getRequestStatus(requestID);
            if (!status.Equals("Waiting for mapping") && !status.Equals("Request mapped"))
            {
                return;
            }
            new MakeSPOsControl(requestID, purchaseManagerControl);
            requestAdapter.modifyRequestStatus(requestID, "Request Mapping");
        }



    }
}

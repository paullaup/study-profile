using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class MakeSPOsControl
    {

        private PurchaseManagerControl purchaseManagerControl;
        private MakeSPOsUI makeSPOsUI;

        private string requestID;

        private RequestAdapter requestAdapter;

        public MakeSPOsControl(string requestID, PurchaseManagerControl purchaseManagerControl)
        {
            this.purchaseManagerControl = purchaseManagerControl;
            this.requestID = requestID;
            requestAdapter = new RequestAdapter();
            makeSPOsUI = new MakeSPOsUI(this, requestID, requestAdapter.getRemark(requestID));
            makeSPOsUI.MdiParent = purchaseManagerControl.getUI();
            makeSPOsUI.Show();
        }

        public void cancel()
        {
            requestAdapter.modifyRequestStatus(requestID, "Waiting for mapping");
        }


    }
}

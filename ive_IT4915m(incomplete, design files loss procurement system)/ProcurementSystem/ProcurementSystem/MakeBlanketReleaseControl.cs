using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ProcurementSystem
{
    internal class MakeBlanketReleaseControl
    {

        private string requestID;

        private PurchaseManagerControl purchaseManagerControl;
        private MakeBlanketReleaseUI makeBlanketReleaseUI;

        private RequestAdapter requestAdapter;
        private BlanketReleaseAdapter blanketReleaseAdapter;
        private RequestLineAdapter requestLineAdapter;

        private ViewBPAControl viewBPAControl;

        public MakeBlanketReleaseControl(string request, PurchaseManagerControl purchaseManagerControl)
        {
            this.requestID = request;
            this.purchaseManagerControl = purchaseManagerControl;
            viewBPAControl = new ViewBPAControl();
            DataTable dt = viewBPAControl.getBPADT(null, null);
            requestAdapter = new RequestAdapter();
            makeBlanketReleaseUI = new MakeBlanketReleaseUI(this, requestID, requestAdapter.getRemark(requestID), dt, requestAdapter.getExpectedDeliveryDate(requestID));
            makeBlanketReleaseUI.MdiParent = purchaseManagerControl.getUI();
            makeBlanketReleaseUI.Show();
            blanketReleaseAdapter = new BlanketReleaseAdapter();
            requestLineAdapter = new RequestLineAdapter();
            Logger.writeLog(" ID : " + purchaseManagerControl.GetAccount().getID() + "purchase manager start to map request with requestID : " + requestID);
        }

        public void submit(BlanketRelease blanketRelease, RequestLine requestLine)
        {
            blanketRelease.SetAccount(purchaseManagerControl.GetAccount());

            if (!blanketReleaseAdapter.addBlanketRelease(blanketRelease))
                return;
            Logger.writeLog(" ID : " + purchaseManagerControl.GetAccount().getID() + ", purchase manager make a blanket release with release number : " + blanketRelease.GetBPAID());
            if (!requestLineAdapter.addRequestLine(requestLine))
                return;
            requestAdapter.mapRequest(requestID, "BPA");
            Logger.writeLog(" ID : " + purchaseManagerControl.GetAccount().getID() + ", purchase manager make a request line with requestID : " + requestLine.GetRequestID() + "with blanket release number : " + blanketRelease.GetBPAID());
            requestAdapter.modifyRequestStatus(requestID, "Request mapped");
            Logger.writeLog(" ID : " + purchaseManagerControl.GetAccount().getID() + "purchase manager submit to map request with requestID : " + requestID);
            makeBlanketReleaseUI.Close();

        }

        public void viewRequestItem()
        {
            new ViewRequestItemControl(requestID);
        }

        public void viewBPAItems(string BPAID)
        {
            new ViewBPAItemsControl(BPAID);
        }

        public string selectDepartmentAddress()
        {
            SelectDepartmentAddress selectDepartmentAddress = new SelectDepartmentAddress();
            if(selectDepartmentAddress.ShowDialog() == DialogResult.OK) 
            {
                return selectDepartmentAddress.txtAddress.Text;
            }
            return "";
        }

        public void cancel()
        {
            requestAdapter.modifyRequestStatus(requestID, "Waiting for mapping");
            Logger.writeLog(" ID : " + purchaseManagerControl.GetAccount().getID() + "purchase manager submit to map request with requestID : " + requestID);
        }

    }
}

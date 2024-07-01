using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcurementSystem
{

    internal class MakeRequesetControl
    {

        private MakeRequestUI makeRequestUI;
        private RestaurantManagerControl restaurantManagerControl;

        private RequestAdapter requestAdapter;
        private ItemAdapter itemAdapter;
        private RequestItemAdapter requestItemAdapter;

        public MakeRequesetControl(RestaurantManagerControl restaurantManagerControl)
        {
            this.restaurantManagerControl = restaurantManagerControl;

            itemAdapter = new ItemAdapter();
            DataTable dt = new DataTable();
            dt.Columns.Add("itemID");
            dt.Columns.Add("quantity");


            makeRequestUI = new MakeRequestUI(this, itemAdapter.getSearchItemTable(restaurantManagerControl.GetAccount().getDeptID()), dt);
            makeRequestUI.MdiParent = restaurantManagerControl.getUI();
            makeRequestUI.Show();
            requestAdapter = new RequestAdapter();
            requestItemAdapter = new RequestItemAdapter();
        }

        public Account getAccount()
        {
            return restaurantManagerControl.GetAccount();
        }

        public void submit(Request request, RequestItem[] requestItems)
        {
            requestAdapter.addRequest(request);
            foreach (RequestItem item in requestItems)
            {
                requestItemAdapter.addRequestItem(item);
            }
            MessageBox.Show("request create successful");
            Logger.writeLog(" ID : " + restaurantManagerControl.GetAccount().getID() + "restaurant manager make request : " + request.getRequestID());
            makeRequestUI.Close();
        }

        






    }
}

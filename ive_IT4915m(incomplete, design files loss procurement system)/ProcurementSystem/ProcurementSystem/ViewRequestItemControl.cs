using ProcurementSystem.YummyRestaurantLimitedDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class ViewRequestItemControl
    {

        private ViewRequestItemUI viewRequestItemUI;
        private RequestAdapter requestAdapter;
        private DataTable requestItem;

        public ViewRequestItemControl(string requestID)
        {
            requestAdapter = new RequestAdapter();
            requestItem = requestAdapter.getRequestItems(requestID);
            viewRequestItemUI = new ViewRequestItemUI(this, requestItem);
            viewRequestItemUI.Show();
        }

        public string getItemFilterCondition(string tableName)
        {
            string condition = "(";
            for(int i = 0; i<requestItem.Rows.Count; i++)
            {
                condition += tableName + " = '" + requestItem.Rows[i]["itemID"] + "'";
                condition += (i != requestItem.Rows.Count - 1) ? " OR " : "";
            }
            return condition + ")";
        }

    }
}

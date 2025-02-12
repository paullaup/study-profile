using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class ViewRequestControl
    {

        private RequestAdapter requestAdapter;

        public ViewRequestControl()
        {
            requestAdapter = new RequestAdapter();
        }

        public DataTable getRequestDT(string name, string condition)
        {
            return requestAdapter.getRequest("RequestQueue", "(status = 'waiting for mapping' or status = 'Request mapped')");
        }


    }
}

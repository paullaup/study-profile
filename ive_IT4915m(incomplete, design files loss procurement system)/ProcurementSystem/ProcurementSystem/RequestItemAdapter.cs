using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class RequestItemAdapter : EntityAdapter
    {

        public RequestItemAdapter() : base()
        {

        }

        public void addRequestItem(RequestItem item)
        {
            string sql = "SELECT * FROM requestItem";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow row = dt.NewRow();
            row["requestID"] = item.getRequestID();
            row["itemID"] = item.getItemID();
            row["quantity"] = item.getQuantity();
            dt.Rows.Add(row);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.Update(dt);
        }

    }
}

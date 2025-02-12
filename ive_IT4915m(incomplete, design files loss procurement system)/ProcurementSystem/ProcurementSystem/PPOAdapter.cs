using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class PPOAdapter : EntityAdapter
    {

        public PPOAdapter() : base()
        {

        }

        public DataTable getPPOdt(string name, string condition)
        {
            // condition should be checked

            DataTable dt = new DataTable(name);
            string sql = "SELECT PPOID, PPOHeader.name, purchaseOrderRevision, createdDate, startDate, endDate, PPOHeader.supplierID, supplierName, PPOHeader.buyerID, Buyer.name AS BuyerName, tentativeSchedules, amount, currency, termsAndCondition" +
                            " FROM PPOHeader, Supplier, Buyer" +
                            " WHERE PPOHeader.supplierID = Supplier.supplierID " +
                            " AND PPOHeader.buyerID = Buyer.buyerID ";
            sql += (condition != null) ? condition : "";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getPPOItemsDT(string name, string PPOID, string condition)
        {
            // condition should be checked

            DataTable dt = new DataTable(name);
            string sql = "SELECT PPOID, Item.itemID, itemName, quantity, UOM, price, PPOLine.categoryID, categoryName, reference" +
                            " FROM PPOLine, Item, Category " + 
                            " WHERE PPOID = '" + PPOID + "'" +
                            " AND PPOLine.itemID = Item.itemID " +
                            " AND PPOLine.categoryID = Category.categoryID";
            sql += (condition != null) ? condition : "";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return dt;
        }

       

    }
}

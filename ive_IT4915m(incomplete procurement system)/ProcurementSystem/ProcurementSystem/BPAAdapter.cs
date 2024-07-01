using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class BPAAdapter : EntityAdapter
    {

        public BPAAdapter() : base()
        {
            
        }


        public DataTable getBPAdt(string name, string condition)
        {
            // condition should be checked

            DataTable dt = new DataTable(name);
            string sql = "SELECT BPAID, BPAName, purchaseOrderRevision, createdDate, startDate, endDate, BPAHeader.supplierID, supplierName, BPAHeader.buyerID, Buyer.name AS BuyerName, amountAgreed, currency, termsAndCondition" +
                            " FROM BPAHeader, Supplier, Buyer" +
                            " WHERE BPAHeader.supplierID = Supplier.supplierID " +
                            " AND BPAHeader.buyerID = Buyer.buyerID ";
            sql += (condition != null) ? condition : "";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getBPAItemsDT(string name, string BPAID, string condition)
        {
            // condition should be checked

            DataTable dt = new DataTable(name);
            string sql = "SELECT BPALines.itemID, itemName, promisedQuantity, UOM, MoQ, price, Category.categoryID, categoryName, quantity, priceBreak, discount, startDate, endDate" +
                            " FROM BPALines, BPAPriceBreak, Item, Category " +
                            " WHERE BPALines.BPAID = '" + BPAID + "'" +
                            " AND BPAPriceBreak.BPAID = BPALines.BPAID " +
                            " AND BPAPriceBreak.itemID = BPALines.itemID" +
                            " AND BPALines.itemID = Item.itemID " +
                            " AND BPALines.category = Category.categoryID ";
            sql += (condition != null) ? condition : "";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return dt;
        }

    }
}

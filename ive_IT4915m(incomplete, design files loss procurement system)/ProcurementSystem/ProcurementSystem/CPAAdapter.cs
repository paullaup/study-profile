using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProcurementSystem
{
    internal class CPAAdapter : EntityAdapter
    {

        public CPAAdapter() : base() 
        {

        }
        

        public DataTable getCPAdt(string name, string condition)
        {
            // condition should be checked

            DataTable dt = new DataTable(name);
            string sql = "SELECT ContractNo, CPAName, createdDate, startDate, endDate, CPA.supplierID, supplierName, CPA.buyerID, Buyer.name, CPA.itemID, itemName, termsAndCondition" +
                            " FROM CPA, Supplier, Buyer, Item" +
                            " WHERE CPA.supplierID = Supplier.supplierID " +
                            " AND CPA.buyerID = Buyer.buyerID " +
                            " AND CPA.itemID = Item.itemID";
            sql += (condition != null) ? condition : "";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return dt;
        }



    }
}

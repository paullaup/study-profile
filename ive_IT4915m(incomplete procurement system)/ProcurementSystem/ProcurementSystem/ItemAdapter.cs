using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcurementSystem
{
    internal class ItemAdapter : EntityAdapter
    {


        public ItemAdapter() : base()
        {
            connStr = ConfigurationManager.AppSettings["dbConnStr"];
        }

        public DataTable getSearchItemTable(string restaurantID)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT Item.itemName, Item.itemID, RestaurantItem.virtualItemID, Category.categoryID, Category.categoryName, Supplier.supplierID, Supplier.supplierName "
                            + " FROM RestaurantItem, Item, Category, Supplier "
                            + " WHERE RestaurantItem.itemID = Item.itemID "
                            + " AND Item.categoryID = Category.categoryID "
                            + " AND Item.supplierID = Supplier.supplierID "
                            + " AND RestaurantItem.restaurantID = '" + restaurantID + "'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return dt;
        }

        public Boolean isVaildItemID(string itemID, string restaurantID)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            string sql = "SELECT itemID FROM RestaurantItem"
                            + " WHERE restaurantID = '" + restaurantID + "'"
                            + " AND itemID = @itemID";
            OleDbCommand cmd = new OleDbCommand(sql, new OleDbConnection(connStr));
            cmd.Parameters.Add("@itemID", OleDbType.VarChar, 10).Value = itemID;
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            return dt.Rows.Count == 1;
        }


    }
}

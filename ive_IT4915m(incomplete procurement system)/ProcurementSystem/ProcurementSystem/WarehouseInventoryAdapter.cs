using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProcurementSystem
{
    internal class WarehouseInventoryAdapter : EntityAdapter
    {


        public WarehouseInventoryAdapter() : base()
        {

        }

        public DataTable getWarehouseInventory(string name, string condition)
        {
            DataTable dt = new DataTable(name);
            string sql = "SELECT inventoryID, Item.itemID, itemName, location, expectedExpiryDate, quantity " +
                            " FROM WarehouseInventory, Item" +
                            " WHERE WarehouseInventory.itemID = Item.itemID ";
            sql += (condition != null) ? " AND " + condition : "";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getWarehouseInventorySum()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT Item.itemID, itemName, SUM(quantity) " +
                            " FROM WarehouseInventory, Item" +
                            " WHERE WarehouseInventory.itemID = Item.itemID " +
                            " GROUP BY Item.itemID, itemName";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return dt;
        }


    }


 }


using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcurementSystem
{
    internal class RequestAdapter : EntityAdapter
    {


        public RequestAdapter() : base()
        {

        }

        // need to be correct
        public DataTable getSearchRequestDataTable(string restaurantID)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT requestID, createdDate, Item.itemName, expectedDeliveryDate, status, remark"
                            + " FROM Request, Item"
                            + " WHERE restaurantID = '" + restaurantID + "'"
                            + " AND Item.itemID = Request.itemID";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return dt;
        }


        public void modifyRequest(Request request)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Request WHERE requestID = 3";
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = new OleDbCommand(sql, new OleDbConnection(connStr));
            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(adapter);
            adapter.Fill(dt);
            dt.Rows[0]["expectedDeliveryDate"] = request.getExpectedDeliveryDate();
            dt.Rows[0]["remark"] = request.getRemark();
            adapter.Update(dt);
            MessageBox.Show("request update successfully, ");
        }
        // need to be correct

        public int getLatestRequestID()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT MAX(requestID) FROM Request", new OleDbConnection(connStr));
            adapter.Fill(dt);
            return (int)dt.Rows[0][0];
        }

        public void addRequest(Request request)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM request", new OleDbConnection(connStr));
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow row = dt.NewRow();
            row["requestID"] = request.getRequestID();
            row["restaurantID"] = request.getRestaurantID();
            row["staffID"] = request.getStaffID();
            row["createdDate"] = request.getCreatedDate();
            row["expectedDeliveryDate"] = request.getExpectedDeliveryDate();
            row["status"] = request.getStatus();
            row["remark"] = request.getRemark();
            dt.Rows.Add(row);
            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(adapter);
            adapter.Update(dt);

        }


        public DataTable getRequest(string name, string condition)    
        {
            //condition must be check before calling the function to avoid sql injection
            DataTable dt = new DataTable(name);
            string sql = "SELECT requestID, Request.restaurantID, deptName, createdDate, expectedDeliveryDate, Request.status, Request.remark " +
                            " FROM Request, Department " +
                            " WHERE Request.restaurantID = Department.deptID ";
            if(condition != null)
            {
                sql += " And " + condition;
            }
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getRequestItems(string requestID)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT Item.itemID, categoryName, itemName, quantity " +
                            " FROM RequestItem, Item, Category " +
                            " WHERE RequestItem.itemID = Item.itemID " +
                            " AND Item.categoryID = Category.categoryID " +
                            " AND requestID = ?";
            OleDbCommand cmd = new OleDbCommand(sql, new OleDbConnection(connStr));
            cmd.Parameters.Add("@requestID", OleDbType.Integer ).Value = requestID;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);            
            return dt;
        }

        public string getRequestStatus(string requestID)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT status FROM Request WHERE requestID = ?";
            OleDbCommand cmd = new OleDbCommand(sql, new OleDbConnection(connStr));
            cmd.Parameters.Add("@requestID", OleDbType.Integer).Value = requestID;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            return (dt.Rows.Count==0)? "":dt.Rows[0]["status"].ToString();
        }

        public void modifyRequestStatus(string requestID, string status)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Request WHERE requestID = ?";
            OleDbCommand cmd = new OleDbCommand(sql, new OleDbConnection(connStr));
            cmd.Parameters.Add("@requestID", OleDbType.Integer).Value = requestID;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            dt.Rows[0]["status"] = status;
            OleDbCommandBuilder oleDbCommandBuilder = new OleDbCommandBuilder(adapter);
            adapter.Update(dt);
        }

        public string getRemark(string requestID)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT remark FROM request WHERE requestID = ?";
            OleDbCommand cmd = new OleDbCommand(sql, new OleDbConnection(connStr));
            cmd.Parameters.Add("@requestID", OleDbType.Integer).Value = requestID;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            return (dt.Rows.Count == 0) ? "" : dt.Rows[0]["remark"].ToString();
        }

        public DateTime getExpectedDeliveryDate(string requestID)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT expectedDeliveryDate FROM Request WHERE requestID = ?";
            OleDbCommand cmd = new OleDbCommand(sql, new OleDbConnection(connStr));
            cmd.Parameters.Add("@requestID", OleDbType.Integer).Value = requestID;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            return (dt.Rows.Count == 0) ? DateTime.MinValue : Convert.ToDateTime(dt.Rows[0]["expectedDeliveryDate"]);
        }

        public void mapRequest(string requestID, string mapType)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Request" +
                            " WHERE requestID = ?";
            OleDbCommand cmd = new OleDbCommand(sql, new OleDbConnection(connStr));
            cmd.Parameters.Add("@requestID", OleDbType.Integer).Value = requestID;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            dt.Rows[0]["mapType"] = mapType;
            OleDbCommandBuilder cmdBuilder = new OleDbCommandBuilder(adapter);
            adapter.Update(dt);
        }

        public string getRequestIDByRequestLine(int PONumber, string mapType)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT Request.requestID FROM Request, RequestLine " +
                            " WHERE Request.requestID = RequestLine.requestID " +
                            " AND PONumber = ? " +
                            " AND mapType = ? ";
            MessageBox.Show(PONumber.ToString() + mapType);
            OleDbCommand cmd = new OleDbCommand(sql, new OleDbConnection(connStr));
            cmd.Parameters.Add("@PONumber", OleDbType.Integer).Value = PONumber;
            cmd.Parameters.Add("@mapType", OleDbType.VarChar,50).Value = mapType;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            return dt.Rows[0]["requestID"].ToString();
        }

    }
}

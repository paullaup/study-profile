using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProcurementSystem
{
    internal class RequestLineAdapter : EntityAdapter
    {

        public RequestLineAdapter() : base()
        {

        }

        public bool addRequestLine(RequestLine requestLine)
        {
            try
            {
                string sql = "SELECT * FROM RequestLine";
                DataTable dt = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
                adapter.Fill(dt);
                DataRow row = dt.NewRow();
                row["requestID"] = requestLine.GetRequestID();
                row["PONumber"] = requestLine.GetPurchaseOrder().getPONumber();
                row["otherShipmentInformation"] = requestLine.GetOtherShipmentInformation();
                dt.Rows.Add(row);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                adapter.Update(dt);
            } catch (Exception ex)
            {
                MessageBox.Show("Error in creating requestLine");
                return false;
            }
            return true;
            
        }

        public void addDeliveryNote(string requestID, string instuctionID, DeliveryNote deliveryNote, string otherShipmentInfo)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM RequestLine " +
                            " WHERE RequestID = ? " +
                            " AND PONumber = ?";
            OleDbCommand cmd = new OleDbCommand(sql, new OleDbConnection(connStr));
            cmd.Parameters.Add("@requestID", OleDbType.Integer).Value = requestID;
            cmd.Parameters.Add("@instructionNo", OleDbType.Integer).Value = instuctionID;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            dt.Rows[0]["deliveryNoteNumber"] = deliveryNote.GetDeliveryNoteNumber();
            dt.Rows[0]["otherShipmentInformation"] = otherShipmentInfo;
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.Update(dt);
        }



    }
}

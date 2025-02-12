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
    internal class DespatchInstructionAdapter : EntityAdapter
    {

        public DespatchInstructionAdapter() : base()
        {

        }

        public int getLatestedInstructionID()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT MAX(instructionID) AS MaxInstructionID FROM DespatchInstruction";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return (dt.Rows.Count == 0 || dt.Rows[0]["MaxInstructionID"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[0]["MaxInstructionID"]);

        }

        public bool addDespatchInstruction(DespatchInstruction despatchInstruction)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM DespatchInstruction";
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
                adapter.Fill(dt);
                DataRow row = dt.NewRow();
                row["instructionID"] = despatchInstruction.getPONumber();
                row["status"] = despatchInstruction.getStatus();    
                dt.Rows.Add(row);
                OleDbCommandBuilder cmdBuilder = new OleDbCommandBuilder(adapter);
                adapter.Update(dt);
            } catch(Exception ex)
            {
                MessageBox.Show("Error in creating Despatch Instruction");
                return false;
            }
            MessageBox.Show("Despatch instruction made");
            return true;
        }

        public DataTable getDespatchInstructionDT(string name, string condition)
        {
            DataTable dt = new DataTable(name);
            string sql = "SELECT Address, instructionID, DespatchInstruction.status " +
                            " FROM DespatchInstruction, Request, RequestLine, Department " +
                            " Where Request.requestID = RequestLine.requestID " +
                            " AND DespatchInstruction.instructionID = RequestLine.PONumber" +
                            " AND mapType = 'Warehouse' " +
                            " AND Request.restaurantID = Department.deptID "
                            ;
            sql += (condition != null) ? " AND " + condition : "";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return dt;
        }

        public void modifyInstructionStatus(string instructionID, string status)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM DespatchInstruction WHERE instructionID = ?";
            OleDbCommand command = new OleDbCommand(sql, new OleDbConnection(connStr));
            command.Parameters.Add("@instructionID", OleDbType.Integer).Value = instructionID;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            dt.Rows[0]["status"] = status;
            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(adapter);
            adapter.Update(dt);
        }

    }
}

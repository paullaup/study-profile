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
    internal class ScheduleReleaseAdapter : EntityAdapter
    {

        public ScheduleReleaseAdapter() : base()
        {

        }

        public int getLatestReleaseNumber()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT MAX(releaseNumber) as MAXreleaseNumber FROM ScheduleRelease";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return (dt.Rows.Count == 0 || dt.Rows[0]["MAXreleaseNumber"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[0]["MAXreleaseNumber"]);
        }

        public bool addScheduleRelease(ScheduleRelease scheduleRelease)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM ScheduleRelease";
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
                adapter.Fill(dt);
                DataRow row = dt.NewRow();
                row["releaseNumber"] = scheduleRelease.GetReleaseNumber();
                row["createdDate"] = scheduleRelease.GetCreatedDate();
                row["expectedDeliveryDate"] = scheduleRelease.GetExpectedDeliveryDate();
                row["PPOID"] = scheduleRelease.GetPPOID();
                dt.Rows.Add(row);
                OleDbCommandBuilder cmdBuilder = new OleDbCommandBuilder(adapter);
                adapter.Update(dt);
            } catch (Exception ex)
            {
                MessageBox.Show("Error in creating schedule release");
                return false;
            }
            MessageBox.Show("schedule release with release number " + scheduleRelease.GetReleaseNumber() + "created successfully");
            return true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProcurementSystem
{
    internal class AccountAdapter : EntityAdapter
    {

        private YummyRestaurantLimitedDataSet dataSet;


        public AccountAdapter() : base()
        {
            dataSet = new YummyRestaurantLimitedDataSet();
        }

        public string verify(string staffID, string password)
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                OleDbCommand cmd = new OleDbCommand("SELECT positionName FROM ProcurementSystemAcc acc, Employee WHERE Employee.staffID = acc.staffID AND acc.staffID = @staffID AND password = @password", new OleDbConnection(connStr));
                cmd.Parameters.Add("@staffID", OleDbType.VarChar, 12).Value = staffID;
                cmd.Parameters.Add("@password", OleDbType.VarChar, 20).Value = password;
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                dataAdapter.Dispose();
                cmd.Dispose();
                if (dt.Rows.Count == 0)
                {
                    return "";
                }
                else
                    return dt.Rows[0]["positionName"].ToString();
            } catch (Exception ex)
            {
                return "";
            }
        }




        public bool addAccount(string ID, string password, string[] question, string[] answer)
        {
            YummyRestaurantLimitedDataSetTableAdapters.ProcurementSystemAccTableAdapter adapter = new YummyRestaurantLimitedDataSetTableAdapters.ProcurementSystemAccTableAdapter();
            adapter.Connection = new OleDbConnection(connStr);
            adapter.Fill(dataSet.ProcurementSystemAcc);
            YummyRestaurantLimitedDataSet.ProcurementSystemAccRow row = dataSet.ProcurementSystemAcc.NewProcurementSystemAccRow();
            row.SetField("staffID", ID);
            row.SetField("password", password);
            try
            {
                dataSet.ProcurementSystemAcc.AddProcurementSystemAccRow(row);
                adapter.Update(dataSet.ProcurementSystemAcc);
                addSecurityAnswer(ID, question, answer);
            } catch (Exception ex)
            {
                return false;
            }
            return true;
            
        }

        public bool checkAccount(string staffID)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand("SELECT COUNT(staffID) FROM ProcurementSystemAcc WHERE staffID = @staffID GROUP BY staffID", new OleDbConnection(connStr));
            cmd.Parameters.Add("@staffID", OleDbType.VarChar, 12).Value = staffID;
            try
            {
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                adapter.Dispose();
                cmd.Dispose();
                if(dt.Rows.Count != 1)
                {
                    return false;
                }
            } catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        public void addSecurityAnswer(string staffID, string[] questions, string[] answers)
        {
            YummyRestaurantLimitedDataSetTableAdapters.AccountSecurityAnswerTableAdapter adapter = new YummyRestaurantLimitedDataSetTableAdapters.AccountSecurityAnswerTableAdapter();
            adapter.Connection = new OleDbConnection(connStr);
            adapter.Fill(dataSet.AccountSecurityAnswer);
            for(int i = 0; i < questions.Length; i++)
            {
                YummyRestaurantLimitedDataSet.AccountSecurityAnswerRow row = dataSet.AccountSecurityAnswer.NewAccountSecurityAnswerRow();
                row.SetField("staffID", staffID);
                row.SetField("questionID", getQuestionID(questions[i]));
                row.SetField("securityAnswer", answers[i]);
                dataSet.AccountSecurityAnswer.AddAccountSecurityAnswerRow(row);
            }
            adapter.Update(dataSet.AccountSecurityAnswer);
        }

        public string getQuestionID(string text)
        {
            DataTable dt = new DataTable();
            string sqlStr = "SELECT questionID FROM AccountSecurityQuestion WHERE questionText = '" + text + "'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sqlStr, connStr);
            adapter.Fill(dt);
            return dt.Rows[0]["questionID"].ToString();
        } 

        public string[] getQuestion(string staffID)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand("SELECT questionText FROM AccountSecurityQuestion, AccountSecurityAnswer WHERE AccountSecurityAnswer.staffID = @staffID AND AccountSecurityAnswer.questionID = AccountSecurityQuestion.questionID", new OleDbConnection(connStr));
            cmd.Parameters.Add("@staffID", OleDbType.VarChar, 12).Value = staffID;
            try
            {
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                adapter.Dispose();
                cmd.Dispose();  
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return dt.AsEnumerable().Select(r => r.Field<string>("questionText")).ToArray();
        }



        public string getPosition(string ID)
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand("SELECT positionName FROM Employee WHERE staffID = ?", new OleDbConnection(connStr));
            cmd.Parameters.Add("staffID", OleDbType.VarChar, 12).Value = ID;
            DataTable dt = new DataTable();
            try
            {
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                dataAdapter.Dispose();
                cmd.Dispose();
                if (dt.Rows.Count == 0)
                {
                    return "";
                }
                else
                    return dt.Rows[0]["positionName"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
                return "";
            }
        }

        public string[] getQuestion()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT questionText FROM AccountSecurityQuestion", connStr);
            adapter.Fill(dt);
            adapter.Dispose();
            return dt.AsEnumerable().Select(r => r.Field<string>("questionText")).ToArray();
        }

        public bool verifySecurityAnswer(string staffID, string questionID, string answer)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            string sqlStr = "SELECT COUNT(*) FROM AccountSecurityAnswer WHERE staffID = @staffID AND questionID = @questionID AND securityAnswer = @answer GROUP BY staffID, questionID";
            OleDbCommand cmd = new OleDbCommand(sqlStr, new OleDbConnection(connStr));
            cmd.Parameters.Add("@staffID", OleDbType.VarChar, 12).Value = staffID;
            cmd.Parameters.Add("@questionID", OleDbType.Char, 4).Value = questionID;
            cmd.Parameters.Add("@answer", OleDbType.VarChar, 30).Value = answer;
            try
            {
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                dataAdapter.Dispose();
                cmd.Dispose();
                if (dt.Rows.Count != 1)
                    return false;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public string getPassword(string staffID)
        {
            DataTable dt = new DataTable();
            string sqlStr = "SELECT password FROM ProcurementSystemAcc WHERE staffID = '" + staffID + "'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sqlStr, connStr);
            adapter.Fill(dt);
            return dt.Rows[0]["password"].ToString();
        }

        public string getEmpDepartment(string staffID)
        {
            DataTable dt = new DataTable();
            string sqlStr = "SELECT deptID FROM Employee WHERE staffID = '" + staffID + "'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sqlStr, connStr);
            adapter.Fill(dt);
            adapter.Dispose();
            return dt.Rows[0]["deptID"].ToString();
        }




    }
}

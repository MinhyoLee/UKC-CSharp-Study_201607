using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Housekeeping 
{
    public static class HKPDB
    {
        public static SqlConnection GetConnection()
        {
            string ConStr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\HousekeepingBook\HousekeepingBook\ListDB.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConStr);
            return con;
        }
        public static void AddData(string date, string debit, string uselist, string cashcard, string amount, string customer)
        {
            string insMsg = "INSERT INTO UseTB (Date, debit, useList, CashCard, Amount, customer) VALUES (@date, @debit, @uselist, @cashcard, @amount, @customer)";
            SqlConnection con = GetConnection();
            SqlCommand insCmd = new SqlCommand(insMsg, con);
            insCmd.Parameters.AddWithValue("@date", date);
            insCmd.Parameters.AddWithValue("@debit", debit);
            insCmd.Parameters.AddWithValue("@uselist", uselist);
            insCmd.Parameters.AddWithValue("@cashcard", cashcard);
            insCmd.Parameters.AddWithValue("@amount", amount);
            insCmd.Parameters.AddWithValue("@customer", customer);
            try { con.Open(); insCmd.ExecuteNonQuery(); }
            catch (SqlException ex) { throw ex; }
            finally { con.Close(); }
        }
        public static List<GetData> GetUseList()
        {
            List<GetData> dataList = new List<GetData>();
            SqlConnection con = GetConnection();
            string selStr = "SELECT * FROM UseTB ORDER BY date";
            SqlCommand sqlCmd = new SqlCommand(selStr, con);
            try
            {
                con.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    GetData getData = new GetData();
                    getData.Date = reader["Date"].ToString();
                    getData.Debit = reader["debit"].ToString();
                    getData.UseList = reader["useList"].ToString();
                    getData.CashCard = reader["CashCard"].ToString();
                    getData.Amount = reader["Amount"].ToString();
                    getData.Customer = reader["customer"].ToString();
                    dataList.Add(getData);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { con.Close(); }
            return dataList;
        }
    }
}
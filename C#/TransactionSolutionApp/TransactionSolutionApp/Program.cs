using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace TransactionSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string conString = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
            var con = new SqlConnection(conString);
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();

            string sqlQuery1 = "UPDATE customer SET BALANCE = BALANCE - 5000 WHERE id = 101";
            var cmd1 = new SqlCommand(sqlQuery1, con);
            cmd1.Transaction = transaction;
            string sqlQuery2 = "UPDATE MERCHANTS SET BAL = BAL + 5000 WHERE MID = 1001 ";
            var cmd2 = new SqlCommand(sqlQuery2, con);
            cmd2.Transaction = transaction;

            try
            {
                int res1 = cmd1.ExecuteNonQuery();
                int res2 = cmd2.ExecuteNonQuery();

                if(res1!=0 && res2!=0)
                {
                    transaction.Commit();
                    Console.WriteLine("Transaction Succesfull");
                }
                else
                {
                    transaction.Rollback();
                }
            }
            catch (Exception e)
            {
                transaction.Rollback();
                Console.WriteLine("Transaction Failed: " + e.Message);
            }
            finally
            {

                string sqlQuery = "SELECT * FROM MERCHANTS";
                var cmd = new SqlCommand(sqlQuery, con);
                var dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader[0].ToString() + " " + dataReader[1].ToString() + " " + dataReader[2].ToString());
                }
                dataReader.Close();

                sqlQuery = "SELECT * FROM customer";
                cmd = new SqlCommand(sqlQuery, con);
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader["id"].ToString() + " " + dataReader["name"].ToString() + " " + dataReader["balance"].ToString());
                }

                if (con.State.Equals(ConnectionState.Open))
                {
                    con.Close();
                }
            }

            Console.ReadLine();
        }
    }
}

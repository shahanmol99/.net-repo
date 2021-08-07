using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TransactionViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string conString = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
            var con = new SqlConnection(conString);
            try
            {
                con.Open();

                string sqlQuery = "UPDATE customer SET BALANCE = BALANCE - 5000 WHERE id = 101";
                var cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();

                sqlQuery = "UPDATE MERCHANTS SET BAL = BAL + 5000 WHERE MID = 1001 ";
                cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();

                sqlQuery = "SELECT * FROM MERCHANTS";
                cmd = new SqlCommand(sqlQuery, con);
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
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(con.State.Equals(ConnectionState.Open))
                {
                    con.Close();
                }
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AdoSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string conString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(conString);
            try
            {
                sqlCon.Open();

                Console.WriteLine("DataBase Name: " + sqlCon.Database);
                Console.WriteLine("Database ConnectionTimeout: " + sqlCon.ConnectionTimeout);
                Console.WriteLine("DataBase State: " + sqlCon.State);

                Insert(sqlCon);
                Update(sqlCon);
                Delete(sqlCon);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(sqlCon.State.Equals(ConnectionState.Open))
                {
                    sqlCon.Close();
                    Console.WriteLine("Connection Closed");
                }
            }
            Console.ReadLine();
        }

        private static void Delete(SqlConnection sqlCon)
        {
            string queryString = "delete from customer where name = 'pppp'";
            SqlCommand cmd = new SqlCommand(queryString, sqlCon);
            cmd.ExecuteNonQuery();
            Console.WriteLine("\n------After Delete Operation-----");
            Display(sqlCon);
        }

        private static void Update(SqlConnection sqlCon)
        {
            string queryString = "update customer set name = 'pppp' where name = 'kkkk'";
            SqlCommand cmd = new SqlCommand(queryString, sqlCon);
            cmd.ExecuteNonQuery();
            Console.WriteLine("\n------After Update Operation-----");
            Display(sqlCon);
        }

        private static void Insert(SqlConnection sqlCon)
        {
            string queryString = "insert into customer (id, name, city) " +
                                  "values(91, 'kkkk', 'Mumbai')";
            SqlCommand cmd = new SqlCommand(queryString, sqlCon);
            cmd.ExecuteNonQuery();
            Console.WriteLine("\n------After Insert Operation-----");
            Display(sqlCon);
        }

        private static void Display(SqlConnection sqlCon)
        {
            string queryString = "Select * from customer";
            SqlCommand cmd = new SqlCommand(queryString, sqlCon);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
            }
            reader.Close();
        }
    }
}

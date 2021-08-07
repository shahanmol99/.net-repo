using System;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace MySqlSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string conString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            MySqlConnection sqlCon = new MySqlConnection(conString);
            try
            {
                sqlCon.Open();
                Console.WriteLine("Reading Data From Mysql");

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
                if (sqlCon.State.Equals(ConnectionState.Open))
                {
                    sqlCon.Close();
                    Console.WriteLine("Connection Closed");
                }
            }
            Console.ReadLine();
        }

        private static void Delete(MySqlConnection sqlCon)
        {
            string queryString = "delete from customer where name = 'pppp'";
            MySqlCommand cmd = new MySqlCommand(queryString, sqlCon);
            cmd.ExecuteNonQuery();
            Console.WriteLine("\n------After Delete Operation-----");
            Display(sqlCon);
        }

        private static void Update(MySqlConnection sqlCon)
        {
            string queryString = "update customer set name = 'pppp' where name = 'kkkk'";
            MySqlCommand cmd = new MySqlCommand(queryString, sqlCon);
            cmd.ExecuteNonQuery();
            Console.WriteLine("\n------After Update Operation-----");
            Display(sqlCon);
        }

        private static void Insert(MySqlConnection sqlCon)
        {
            string queryString = "insert into customer (id, name, city) " +
                                  "values(91, 'kkkk', 'Mumbai')";
            MySqlCommand cmd = new MySqlCommand(queryString, sqlCon);
            cmd.ExecuteNonQuery();
            Console.WriteLine("\n------After Insert Operation-----");
            Display(sqlCon);
        }

        private static void Display(MySqlConnection sqlCon)
        {
            string queryString = "Select * from customer";
            MySqlCommand cmd = new MySqlCommand(queryString, sqlCon);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
            }
            reader.Close();
        }
    }
}

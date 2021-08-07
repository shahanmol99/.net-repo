using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace ParameterizedQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            string conString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            var con = new SqlConnection(conString);
            con.Open();

            Console.Write("Enter EmpNo: ");
            var empno = Console.ReadLine();
            string queryString = "SELECT * FROM EMP WHERE EMPNO = @empNo";
            var cmd = new SqlCommand(queryString, con);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@EmpNo";
            param.Value = empno;
            cmd.Parameters.Add(param);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GridViewApp
{
    public partial class ShowTableForm : Form
    {
        private DataSet dataset;
        public ShowTableForm()
        {
            string conString = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
            var con = new SqlConnection(conString);
            dataset = new DataSet();

            try
            {
                con.Open();

                string sqlQuery = "SELECT * FROM EMP";
                var empAdapter = new SqlDataAdapter(sqlQuery, con);
                empAdapter.Fill(dataset, "Employess");

                sqlQuery = "SELECT * FROM DEPT";
                var deptAdapter = new SqlDataAdapter(sqlQuery, con);
                deptAdapter.Fill(dataset, "Departments");
            }
            catch(Exception e)
            {
                Console.WriteLine("Errr!!! Something Went Wrong: " + e.Message);
            }
            finally
            {
                if (con.State.Equals(ConnectionState.Open))
                {
                    con.Close();
                }
            }
            InitializeComponent();
        }

        private void ShowTable(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if(button.Text.Equals("Show Emp"))
            {
                this.dataGridView1.DataSource = dataset.Tables["Employess"];
                return;
            }

            this.dataGridView1.DataSource = dataset.Tables["Departments"];
        }
    }
}

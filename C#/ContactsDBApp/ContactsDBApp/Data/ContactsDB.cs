using ContactsDBApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Data;

namespace ContactsDBApp.Data
{
    class ContactsDB : DataAccess
    {
        string _conString;
        SqlConnection _sqlCon;
        List<Contact> _contactList;

        public ContactsDB()
        {
            _conString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            _sqlCon = new SqlConnection(_conString);
            _contactList = new List<Contact>();
        }

        public List<Contact> GetContacts()
        {
            try
            {
                if (_sqlCon.State.Equals(ConnectionState.Closed))
                {
                    _sqlCon.Open();
                }

                string queryString = "SELECT * FROM CONTACTS";
                SqlCommand cmd = new SqlCommand(queryString, _sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();

                string contactName, contactNumber;
                while (reader.Read())
                {
                    contactName = reader[0].ToString();
                    contactNumber = reader[1].ToString();
                    _contactList.Add(new Contact(contactName, contactNumber));
                }
                reader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Errr! Something Went Wrong");
            }

            return _contactList;
        }

        public void AddContacts(string name, string contactNumber)
        {
            try
            {
                string queryString = "INSERT INTO CONTACTS(NAME, NUMBER) VALUES('" + name + "', '" + contactNumber + "')";
                SqlCommand cmd = new SqlCommand(queryString, _sqlCon);
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine("Errr Something Went Wrong");
            }
            
        }

        public void CloseDB()
        {
            if (_sqlCon.State.Equals(ConnectionState.Open))
            {
                _sqlCon.Close();
                Console.WriteLine("DB Connection Closed");
            }
        }
    }
}

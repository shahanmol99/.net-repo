using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ContactsLibrary.Model;
using System.Linq;
using System.Text;

namespace ContactsLibrary.Data
{
    public class ContactsSqlDB : DataAccess
    {
        private string _conString;
        private SqlConnection _sqlCon;

        public ContactsSqlDB()
        {
            _conString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            _sqlCon = new SqlConnection(_conString);
        }

        public List<Contact> GetContacts()
        {
            var _contactList = new List<Contact>();
            try
            {
                if (_sqlCon.State.Equals(ConnectionState.Closed))
                {
                    _sqlCon.Open();
                }

                string queryString = "SELECT * FROM CONTACTS ORDER BY NAME";
                SqlCommand cmd = new SqlCommand(queryString, _sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();

                string contactName, contactNumber, contactId;
                while (reader.Read())
                {
                    contactId = reader[0].ToString();
                    contactName = reader[1].ToString();
                    contactNumber = reader[2].ToString();
                    _contactList.Add(new Contact(contactId, contactName, contactNumber));
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Errr! Something Went Wrong: " + e.Message);
            }

            return _contactList;
        }

        public bool AddContacts(string name, string contactNumber, string address, string street, string city,string pincode)
        {
            if (_sqlCon.State.Equals(ConnectionState.Closed))
            {
                _sqlCon.Open();
            }

            Guid id = Guid.NewGuid();

            string addressQuery = "INSERT INTO CONTACTADD VALUES(@guid, @address, @street, @city, @pincode)";
            var addressCmd = new SqlCommand(addressQuery, _sqlCon);
            SqlParameter[] addressParam = new SqlParameter[5];
            addressParam[0] = new SqlParameter("@guid", id.ToString());
            addressParam[1] = new SqlParameter("@address", address);
            addressParam[2] = new SqlParameter("@street", street);
            addressParam[3] = new SqlParameter("@city", city);
            addressParam[4] = new SqlParameter("@pincode", pincode);
            addressCmd.Parameters.Add(addressParam[0]);
            addressCmd.Parameters.Add(addressParam[1]);
            addressCmd.Parameters.Add(addressParam[2]);
            addressCmd.Parameters.Add(addressParam[3]);
            addressCmd.Parameters.Add(addressParam[4]);

            string contactString = "INSERT INTO CONTACTS VALUES(@guid, @name, @number)";
            SqlCommand contactCmd = new SqlCommand(contactString, _sqlCon);
            SqlParameter[] contactParam = new SqlParameter[3];
            contactParam[0] = new SqlParameter("@guid", id.ToString());
            contactParam[1] = new SqlParameter("@name", name);
            contactParam[2] = new SqlParameter("@number", contactNumber);
            contactCmd.Parameters.Add(contactParam[0]);
            contactCmd.Parameters.Add(contactParam[1]);
            contactCmd.Parameters.Add(contactParam[2]);

            SqlTransaction transaction = _sqlCon.BeginTransaction();
            addressCmd.Transaction = transaction;
            contactCmd.Transaction = transaction;

            try
            {
                contactCmd.ExecuteNonQuery();
                addressCmd.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                transaction.Rollback();
                return false;
            }

        }

        public List<ContactsWithAddress> GetContactAndAddress()
        {
            var _contactList = new List<ContactsWithAddress>();

            if (_sqlCon.State.Equals(ConnectionState.Closed))
            {
                _sqlCon.Open();
            }

            string queryString = "SELECT * FROM CONTACTS AS C INNER JOIN CONTACTADD AS A ON C.ID = A.ID ORDER BY NAME";
            SqlCommand cmd = new SqlCommand(queryString, _sqlCon);
            SqlDataReader reader = cmd.ExecuteReader();

            string id, contactName, contactNumber, address, street, city, pincode;
            while (reader.Read())
            {
                id = reader[0].ToString();
                contactName = reader[1].ToString();
                contactNumber = reader[2].ToString();
                address = reader[4].ToString();
                street = reader[5].ToString();
                city = reader[6].ToString();
                pincode = reader[7].ToString();

                _contactList.Add(new ContactsWithAddress(id, contactName, contactNumber, address, street, city, pincode));
            }
            reader.Close();

            return _contactList;
        }

        public bool AddAddress(string id, string address, string street, string city, string pin)
        {
            if (_sqlCon.State.Equals(ConnectionState.Closed))
            {
                _sqlCon.Open();
            }

            string addressQuery = "INSERT INTO CONTACTADD VALUES(@guid, @address, @street, @city, @pincode)";
            var addressCmd = new SqlCommand(addressQuery, _sqlCon);
            SqlParameter[] addressParam = new SqlParameter[5];
            addressParam[0] = new SqlParameter("@guid", id);
            addressParam[1] = new SqlParameter("@address", address);
            addressParam[2] = new SqlParameter("@street", street);
            addressParam[3] = new SqlParameter("@city", city);
            addressParam[4] = new SqlParameter("@pincode", pin);
            addressCmd.Parameters.Add(addressParam[0]);
            addressCmd.Parameters.Add(addressParam[1]);
            addressCmd.Parameters.Add(addressParam[2]);
            addressCmd.Parameters.Add(addressParam[3]);
            addressCmd.Parameters.Add(addressParam[4]);

            SqlTransaction transaction = _sqlCon.BeginTransaction();
            addressCmd.Transaction = transaction;

            try
            {
                addressCmd.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                transaction.Rollback();
                string msg = e.Message;
                return false;
            }

        }
    }
}

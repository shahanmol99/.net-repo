using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BankApp.Models;
using System.Text;

namespace BankApp.Data
{
    public class BankSqlDB : IDataAccess
    {
        private string _conString;
        private SqlConnection _sqlCon;

        public BankSqlDB()
        {
            _conString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            _sqlCon = new SqlConnection(_conString);
        }

        public bool CheckNameExists(string name)
        {
            if (_sqlCon.State.Equals(ConnectionState.Closed))
            {
                _sqlCon.Open();
            }

            string queryString = "SELECT COUNT(UNAME) FROM BANK_MASTER WHERE UNAME = @name";
            SqlCommand cmd = new SqlCommand(queryString, _sqlCon);
            SqlParameter nameParam = new SqlParameter("@name", name);
            cmd.Parameters.Add(nameParam);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if(count==0)
            {
                return false;
            }

            return true;
        }

        public bool DoTransaction(string name, int bal, string type, int amount)
        {
            if (_sqlCon.State.Equals(ConnectionState.Closed))
            {
                _sqlCon.Open();
            }

            string bankMasterQuery = "UPDATE BANK_MASTER SET BALANCE = @bal WHERE UNAME = @name";
            SqlCommand bankMasterCmd = new SqlCommand(bankMasterQuery, _sqlCon);
            SqlParameter[] bankMasterParams = new SqlParameter[2];
            bankMasterParams[0] = new SqlParameter("@name", name);
            bankMasterParams[1] = new SqlParameter("@bal", bal);
            bankMasterCmd.Parameters.Add(bankMasterParams[0]);
            bankMasterCmd.Parameters.Add(bankMasterParams[1]);

            string bankTransactionQuery = "INSERT INTO BANK_TRANSACTION(UNAME, AMOUNT, TRTYPE, TRDATE) VALUES(@name, @amount, @type, @date)";
            SqlCommand bankTransactionCmd = new SqlCommand(bankTransactionQuery, _sqlCon);
            SqlParameter[] bankTransactionParams = new SqlParameter[4];
            bankTransactionParams[0] = new SqlParameter("@name", name);
            bankTransactionParams[1] = new SqlParameter("@amount", amount);
            bankTransactionParams[2] = new SqlParameter("@type", type);
            bankTransactionParams[3] = new SqlParameter("@date", DateTime.Now.ToString());
            bankTransactionCmd.Parameters.Add(bankTransactionParams[0]);
            bankTransactionCmd.Parameters.Add(bankTransactionParams[1]);
            bankTransactionCmd.Parameters.Add(bankTransactionParams[2]);
            bankTransactionCmd.Parameters.Add(bankTransactionParams[3]);

            SqlTransaction transaction = _sqlCon.BeginTransaction();
            bankMasterCmd.Transaction = transaction;
            bankTransactionCmd.Transaction = transaction;

            try
            {
                int masterInsertResult = bankMasterCmd.ExecuteNonQuery();
                int transactionInsertResult = bankTransactionCmd.ExecuteNonQuery();

                if (masterInsertResult == 0 || transactionInsertResult == 0)
                {
                    transaction.Rollback();
                    return false;
                }
                transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                transaction.Rollback();
                return false;
            }
        }

        public int GetBalance(string name)
        {
            if (_sqlCon.State.Equals(ConnectionState.Closed))
            {
                _sqlCon.Open();
            }

            string queryString = "SELECT * FROM BANK_MASTER WHERE UNAME = @name";
            SqlCommand cmd = new SqlCommand(queryString, _sqlCon);
            SqlParameter nameParam = new SqlParameter("@name", name);
            cmd.Parameters.Add(nameParam);
            var dataReader = cmd.ExecuteReader();

            int balance = 0;
            while (dataReader.Read())
            {
                balance = Convert.ToInt32(dataReader[1].ToString());
            }
            dataReader.Close();
            return balance;

        }

        public string GetTransactionDetails(string name)
        {
            if (_sqlCon.State.Equals(ConnectionState.Closed))
            {
                _sqlCon.Open();
            }

            string queryString = "SELECT * FROM BANK_TRANSACTION WHERE UNAME = @name";
            SqlCommand cmd = new SqlCommand(queryString, _sqlCon);
            SqlParameter nameParam = new SqlParameter("@name", name);
            cmd.Parameters.Add(nameParam);
            var dataReader = cmd.ExecuteReader();

            StringBuilder passbookDetails = new StringBuilder();
            while (dataReader.Read())
            {
                passbookDetails.Append(dataReader[1].ToString());
                passbookDetails.Append(",");
                passbookDetails.Append(dataReader[2].ToString());
                passbookDetails.Append(",");
                passbookDetails.Append(dataReader[3].ToString());
                passbookDetails.Append("\n");
            }

            dataReader.Close();
            return passbookDetails.ToString();

        }

        public bool MatchPassword(string name, string password)
        {
            if (_sqlCon.State.Equals(ConnectionState.Closed))
            {
                _sqlCon.Open();
            }

            string queryString = "SELECT UPASSWORD FROM BANK_MASTER WHERE UNAME = @name";
            SqlCommand cmd = new SqlCommand(queryString, _sqlCon);
            SqlParameter nameParam = new SqlParameter("@name", name);
            cmd.Parameters.Add(nameParam);
            var dataReader = cmd.ExecuteReader();

            string dbpassword = "";
            while (dataReader.Read())
            {
                dbpassword = dataReader["UPASSWORD"].ToString();
            }

            if(password==dbpassword)
            {
                return true;
            }

            dataReader.Close();
            return false;
        }

        public bool RegisterBankUser(string name, int balance, string hashPassword)
        {
            if (_sqlCon.State.Equals(ConnectionState.Closed))
            {
                _sqlCon.Open();
            }

            string bankMasterQuery = "INSERT INTO BANK_MASTER(UNAME, BALANCE, UPASSWORD) VALUES(@name, @balance, @password)";
            SqlCommand bankMasterCmd = new SqlCommand(bankMasterQuery, _sqlCon);
            SqlParameter[] bankMasterParams = new SqlParameter[3];
            bankMasterParams[0] = new SqlParameter("@name", name);
            bankMasterParams[1] = new SqlParameter("@balance", balance);
            bankMasterParams[2] = new SqlParameter("@password", hashPassword);
            bankMasterCmd.Parameters.Add(bankMasterParams[0]);
            bankMasterCmd.Parameters.Add(bankMasterParams[1]);
            bankMasterCmd.Parameters.Add(bankMasterParams[2]);

            string bankTransactionQuery = "INSERT INTO BANK_TRANSACTION(UNAME, AMOUNT, TRTYPE, TRDATE) VALUES(@name, @balance, @type, @date)";
            SqlCommand bankTransactionCmd = new SqlCommand(bankTransactionQuery, _sqlCon);
            SqlParameter[] bankTransactionParams = new SqlParameter[4];
            bankTransactionParams[0] = new SqlParameter("@name", name);
            bankTransactionParams[1] = new SqlParameter("@balance", balance);
            bankTransactionParams[2] = new SqlParameter("@type", "D");
            bankTransactionParams[3] = new SqlParameter("@date", DateTime.Now.ToString());
            bankTransactionCmd.Parameters.Add(bankTransactionParams[0]);
            bankTransactionCmd.Parameters.Add(bankTransactionParams[1]);
            bankTransactionCmd.Parameters.Add(bankTransactionParams[2]);
            bankTransactionCmd.Parameters.Add(bankTransactionParams[3]);

            SqlTransaction transaction = _sqlCon.BeginTransaction();
            bankMasterCmd.Transaction = transaction;
            bankTransactionCmd.Transaction = transaction;

            try
            {
                int masterInsertResult =  bankMasterCmd.ExecuteNonQuery();
                int transactionInsertResult =  bankTransactionCmd.ExecuteNonQuery();

                if(masterInsertResult==0 || transactionInsertResult==0)
                {
                    transaction.Rollback();
                    return false;
                }
                transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                transaction.Rollback();
                return false;
            }
        }

    }
}
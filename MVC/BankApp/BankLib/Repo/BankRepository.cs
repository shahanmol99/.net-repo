using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using BankLib.Model;

namespace BankLib.Repo
{
    class BankRepository
    {
        private SqlConnection _sqlCon;

        public BankRepository()
        {
            string conString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            _sqlCon = new SqlConnection(conString);
            _sqlCon.Open();
        }

        public bool Add(Bank bank)
        {
            string bankMasterQuery = "INSERT INTO BANK_MASTER(UNAME, BALANCE, UPASSWORD) VALUES(@name, @balance, @password)";
            SqlCommand bankMasterCmd = new SqlCommand(bankMasterQuery, _sqlCon);
            SqlParameter[] bankMasterParams = new SqlParameter[3];
            bankMasterParams[0] = new SqlParameter("@name", bank.UserName);
            bankMasterParams[1] = new SqlParameter("@balance", bank.balance);
            bankMasterParams[2] = new SqlParameter("@password", bank.Password);
            bankMasterCmd.Parameters.Add(bankMasterParams[0]);
            bankMasterCmd.Parameters.Add(bankMasterParams[1]);
            bankMasterCmd.Parameters.Add(bankMasterParams[2]);

            string bankTransactionQuery = "INSERT INTO BANK_TRANSACTION(UNAME, AMOUNT, TRTYPE, TRDATE) VALUES(@name, @balance, @type, @date)";
            SqlCommand bankTransactionCmd = new SqlCommand(bankTransactionQuery, _sqlCon);
            SqlParameter[] bankTransactionParams = new SqlParameter[4];
            bankTransactionParams[0] = new SqlParameter("@name", bank.UserName);
            bankTransactionParams[1] = new SqlParameter("@balance", bank.balance);
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

        public List<Transaction> GetTransactions(string userName)
        {
            List<Transaction> transactions = new List<Transaction>();

            string queryString = "SELECT * FROM BANK_TRANSACTION WHERE UNAME = @name";
            SqlCommand cmd = new SqlCommand(queryString, _sqlCon);
            SqlParameter nameParam = new SqlParameter("@name", userName);
            cmd.Parameters.Add(nameParam);
            var dataReader = cmd.ExecuteReader();

            string name, type, date;
            double amount;
            while (dataReader.Read())
            {
                name = dataReader["UNAME"].ToString();
                amount = Convert.ToDouble(dataReader["AMOUNT"]);
                type = dataReader["TRTYPE"].ToString();
                date = dataReader["TRDATE"].ToString();

                transactions.Add(new Transaction { UserName = name, Amount = amount, TransactionType = type, TransactionDate = date });
            }

            dataReader.Close();
            return transactions;

        }

    }
}


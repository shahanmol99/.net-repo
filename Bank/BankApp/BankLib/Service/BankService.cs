using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankLib.Model;
using BankLib.Repository;

namespace BankLib.Service
{
    public class BankService : IBankService
    {
        private IRepository<Account> _accountRepo;
        //private IRepository<Transaction> _transactionRepo;

        public BankService()
        {
            _accountRepo = new BankRepositoryDbContext<Account>();
            //_transactionRepo = new BankRepositoryDbContext<Transaction>();
        }

        public bool RegisterBankAccount(Account acc, Transaction transaction)
        {
            acc.Transactions = new List<Transaction>();
            acc.Transactions.Add(transaction);
            return _accountRepo.Add(acc);
            //bool transacationInsertRes = _transactionRepo.Add(transaction);
            
            //if (accInsertRes)
            //{
            //    _accountRepo.Commit();
            //    //_transactionRepo.Commit();
            //    return true;
            //}

            //return false;
        }

        public List<Account> GetAccounts()
        {
            return _accountRepo.Get();
        }

        public Account GetAccountByName(string uName)
        {
            return _accountRepo.GetByName(uName);
        }

        public IEnumerable GetTransctionByName(string uname)
        {
            Account acc = _accountRepo.GetByName(uname);
            if(acc==null)
            {
                return null;
            }
            return acc.Transactions.ToList().Select(t => new { t.TransactionId, t.Amount, t.Type , t.Date});
        }

        public bool AddTransaction(Account acc, Transaction transaction)
        {
            if(transaction.Type=="D")
            {
                acc.Balance = acc.Balance + transaction.Amount;
                acc.Transactions.Add(transaction);
                return _accountRepo.Update(acc);
            }
            else if(transaction.Type=="W" && acc.Balance-transaction.Amount>=500)
            {
                acc.Balance = acc.Balance - transaction.Amount;
                acc.Transactions.Add(transaction);
                return _accountRepo.Update(acc);
            }

            return false;
        }
    }
}

using BankLib.Model;
using System.Collections;
using System.Collections.Generic;

namespace BankLib.Service
{
    public interface IBankService
    {
        List<Account> GetAccounts();
        bool RegisterBankAccount(Account acc, Transaction transaction);
        Account GetAccountByName(string uName);
        IEnumerable GetTransctionByName(string uname);
        bool AddTransaction(Account acc, Transaction transaction);
    }
}
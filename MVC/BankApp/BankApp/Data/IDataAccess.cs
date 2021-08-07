using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Data
{
    interface IDataAccess
    {
        bool CheckNameExists(string name);
        bool RegisterBankUser(string name, int balance, string hashPassword);
        bool MatchPassword(string name,string password);
        bool DoTransaction(string name,int bal, string type, int amount);
        int GetBalance(string name);
        string GetTransactionDetails(string v);
    }
}

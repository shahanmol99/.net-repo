using System;
using System.Collections.Generic;
using System.Text;

namespace AccountInheritanceApp.Model
{
    class SavingAccount : Account
    {

        private double _minBalance = 500;

        public SavingAccount(int accNo, string name) : base(accNo, name, 500)
        {
        }

        public SavingAccount(int accNo, string name, double balance) : base(accNo, name, balance)
        {
        }
        public override void Withdraw(double amount)
        {
            if (base.GetBalance - amount < _minBalance)
            {
                throw new Exception("Insufficient Balance In Account");
            }
            else
            {
                _balance = base.GetBalance - amount;
            }
        }
    }
}

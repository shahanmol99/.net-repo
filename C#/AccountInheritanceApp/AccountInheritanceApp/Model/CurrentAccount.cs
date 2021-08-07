using System;
using System.Collections.Generic;
using System.Text;

namespace AccountInheritanceApp.Model
{
    class CurrentAccount : Account
    {
        private double _minBalance = 1000;

        public CurrentAccount(int accNo, string name) : base(accNo, name, 1000)
        {
        }

        public CurrentAccount(int accNo, string name, double balance) : base(accNo, name, balance)
        {
        }
        public override void Withdraw(double amount)
        {
            if(base.GetBalance-amount<_minBalance)
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

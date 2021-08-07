using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionApp.Model
{
    [Serializable]
    class Account
    {
        int _accNo;
        String _accName;
        double _balance, _minBal = 500;

        public Account(int accNo, String name) : this(accNo, name, 500)
        {
        }
        public Account(int accNo, String name, double balance)
        {
            _accNo = accNo;
            _accName = name;
            _balance = balance;
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }

        public void Withdraw(double amount)
        {
            if(_balance-amount<_minBal)
            {
                throw new Exception("Insufficient Balance");
            }
            else
            {
                _balance = _balance - amount;
            }
        }

        public int AccNo
        {
            get
            {
                return _accNo;
            }
        }

        public String AccName
        {
            get
            {
                return _accName;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
        }
    }
}


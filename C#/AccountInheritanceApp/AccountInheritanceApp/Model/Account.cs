using System;
using System.Collections.Generic;
using System.Text;

namespace AccountInheritanceApp.Model
{
    abstract class Account
    {
        private int _accNo;
        private String _accName;
        protected double _balance;
        private static int count;

        static Account()
        {
            Console.WriteLine("Hello From Static Constructor");
            count = 0;
        }

        public Account(int accNo, String name, double balance)
        {
            _accNo = accNo;
            _accName = name;
            _balance = balance;
            count = count + 1;
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }

        public abstract void Withdraw(double amount);
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

        public double GetBalance
        {
            get
            {
                return _balance;
            }
        }

        protected double SetBalance
        {
            set
            {
                _balance = value;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}


using System;

namespace AccountLib
{
    public delegate void AccountHandler(Account acc);

    public class Account
    {

        int _accNo;
        String _accName;
        double _balance, _minBal = 500;
        public event AccountHandler BalanceChanged;

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
            if (BalanceChanged != null)
            {
                BalanceChanged(this);
            }
        }

        public void Withdraw(double amount)
        {
            if (_balance - amount < _minBal)
            {
                throw new Exception("Insufficient Balance");
            }
            else
            {
                _balance = _balance - amount;
                if (BalanceChanged != null)
                {
                    BalanceChanged(this);
                }
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

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double _balance = 0;
        public void Deposit(double amount)
        {
            _balance = _balance + amount;
            Console.WriteLine($"Deposit Amount: +{amount}"); 
        }

        public double GetBalance() 
        { 
            Console.WriteLine($"Balance: {_balance}");
            return _balance; 
        }

        public void Withdraw(double amount) 
        {
            _balance = _balance - amount;
            Console.WriteLine($"Withdrawal Amount: -{amount}");
        }

        

    }
}

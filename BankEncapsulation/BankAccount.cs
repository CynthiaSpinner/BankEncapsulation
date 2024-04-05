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
        public double Deposit()
        {
            
            

            Console.WriteLine("How much do you want to deposit");
            var amount = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"Deposit Amount: +{amount}");
            _balance = _balance + amount;
            Console.WriteLine($"New Balance: {_balance}");
            return _balance;
        }

        public double GetBalance() 
        { 
            Console.WriteLine($"Balance: {_balance}");
            return _balance; 
        }

        public double Withdraw() 
        {
            
            Console.WriteLine("How much would you like to withdraw");
            var amount = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"Withdrawal Amount: -{amount}");
            _balance = _balance - amount;
            Console.WriteLine($"New Balance: {_balance}");
            return _balance;
        }

        
        
        public bool YesNo()
        {
            Console.WriteLine("Would you like to go to the main screen for another transaction? Please type Yes or No...");
            string yesOrNo = Console.ReadLine();
            if (yesOrNo?.ToLower() == "no")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else if (yesOrNo?.ToLower() == "yes")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect input! Try Again... ");
                return YesNo();
            }
        }

    }
}

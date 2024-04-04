using System.ComponentModel;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine($"Welcome to Cynthia's Union Bank\n -------------------------------");

            Console.WriteLine($"What would you like to do today?\n Deposit\t Withdraw\t Check Balance");

            Console.ReadLine();

            account.GetBalance();

            account.Deposit(550.34);

            account.GetBalance();

            account.Withdraw(34.23);

            account.GetBalance();
            
        }

     
    }
}

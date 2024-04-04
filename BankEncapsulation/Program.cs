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
            string userInput = Console.ReadLine();
            account.Pin();
             

            if ( userInput == "Balance")
            {
                account.GetBalance();
            }
            
            if ( userInput == "Withdraw")
            {
                account.Withdraw();
            }
            if ( userInput == "Deposit")
            {
                account.Deposit();
            }

            
        }

     
    }
}

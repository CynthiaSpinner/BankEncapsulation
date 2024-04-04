using System.ComponentModel;
using System.Security.Principal;

namespace BankEncapsulation
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine($"Welcome to Cynthia's Union Bank\n -------------------------------");


            Operations(account);
                                   
        }

        static void Operations(BankAccount account)
        {
            

            Console.WriteLine($"What would you like to do today?\n Deposit\t Withdraw\t Check Balance");

            string userInput = Console.ReadLine();
            

            if (userInput == "Balance")
            {
                account.Pin();
                account.GetBalance();

            }

            else if (userInput == "Withdraw")
            {
                account.Pin();
                account.Withdraw();
            }
            else if (userInput == "Deposit")
            {
                account.Pin();
                account.Deposit();
            }
     
            else
            {
                Console.WriteLine("Wrong input please tell me what you'd like to do");
                
            }
            
            if (account.YesNo()) 
            { 
                Operations(account);
            }
            
            
        }
     
    }
}

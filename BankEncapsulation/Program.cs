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

            Pin();

            Operations(account);
                                   
        }
        private static bool Pin()
        {
            Console.WriteLine("Please Enter your Pin");
            var number = int.Parse(Console.ReadLine());

            if (number == 1234)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Wrong Pin");

                return Pin();
            }
        }
        static void Operations(BankAccount account)
        {
            

            Console.WriteLine($"What would you like to do today?\n Deposit\t Withdraw\t Check Balance");

            string userInput = Console.ReadLine();
            

            if (userInput?.ToLower() is "check balance" or "balance")
            {
                
                account.GetBalance();

            }

            else if (userInput == "withdraw")
            {
                
                account.Withdraw();
            }
            else if (userInput == "deposit")
            {
                
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

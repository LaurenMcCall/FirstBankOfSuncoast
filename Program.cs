using System;
using System.Collections.Generic;

namespace FirstBankOfSuncoast
{
    class Transaction
    {
        public string Account { get; set; }
        public string Amount { get; set; }
        public string TransactionType { get; set; }
    }

    class Program
    {
        static void DisplayGreeting()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰");
            Console.WriteLine("         🤑 Welcome to First Bank of Suncoast 🤑          ");
            Console.WriteLine("💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰💰");
            Console.WriteLine("");
        }

        public string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();

            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isthisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);

            if (isthisGoodInput)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Sorry, that is not a valid input. I'm using 0 as your answer. ");
                return 0;
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("PLEASE MAKE A SELECTION: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("(1) View Account Balances");
            Console.WriteLine("(2) Deposit Funds");
            Console.WriteLine("(3) Withdraw Funds");
            Console.WriteLine("(4) View Transaction History");
            Console.WriteLine("(5) Quit");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");


        }

        static void Main(string[] args)
        {
            DisplayGreeting();

            DisplayMenu();

            var transactions = new List<Transaction>();

        }
    }
}
// ALGORITHM
// Load past transactions from csv file.

// Create a list to store transaction history.
// Create a class called `Transaction`
// - Properties:
//   - savings
//   - checking
// - Behaviors/Methods:
//   - deposit
//   - withdraw
// If user selects `deposit to savings`
// - prompt user to input amount (PromptForInteger)
// - add to savings history
// - update balance
// If user selects `deposit to checking`
// - prompt user to input amount (PromptForInteger)
// - add to checking history
// - update balance
// If user selects `withdraw from savings`
// - prompt user to input amount (PromptForInteger)
// - add amount to savings history
// - update balance
//   - if withdrawal would make balance < 0, display error message
// If user selects `withdraw from checking`
// - prompt user to input amount (PromptForInteger)
// - add to checking history
// - update balance
//   - if withdrawal would make balance < 0, display error message

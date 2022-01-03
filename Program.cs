using System;

namespace FirstBankOfSuncoast
{
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
        // - deposit to savings
        // - deposit to checking
        // - withdraw from savings
        // - withdraw from checking
        // - view balance of savings and checking
        // - view transaction history



        static void Main(string[] args)
        {
            DisplayGreeting();

            DisplayMenu();
        }
    }
}

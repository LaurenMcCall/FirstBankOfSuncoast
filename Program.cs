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

        static void Main(string[] args)
        {
            DisplayGreeting();
        }
    }
}

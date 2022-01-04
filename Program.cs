using System;
using System.Collections.Generic;
using System.Linq;

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
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);

            if (isThisGoodInput)
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
            Console.WriteLine("[B]ALANCES");
            Console.WriteLine("[D]EPOSIT");
            Console.WriteLine("[W]ITHDRAW");
            Console.WriteLine("[T]RANSACTION HISTORY");
            Console.WriteLine("[Q]UIT");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
        }

        // private static int ComputeCheckingBalance(List<Transaction> transactions)
        // {
        //     var totalCheckingDeposits = transactions.Where(transaction => transaction.Account == "Checking" && transaction.Type == "Deposit")
        //                                             .Sum(transaction => transaction.Amount);
        //     var totalCheckingWithdraw = transactions.Where(transaction => transaction.Account == "Checking" && transaction.Type == "Withdraw")
        //                                             .Sum(transaction => transaction.Amount);
        //     var totalChecking = totalCheckingDeposits - totalCheckingWithdraw;
        //     return totalChecking;
        // }


        static void Main(string[] args)
        {
            DisplayGreeting();

            var transactions = new List<Transaction>();
            {
                var firstCheckingDeposit = new Transaction()
                {
                    Amount = 10,
                    Account = "Checking",
                    Type = "Deposit"
                };
                var firstSavingsDeposit = new Transaction()
                {
                    Amount = 10,
                    Account = "Savings",
                    Type = "Deposit"
                };
            };

            var keepGoing = true;

            while (keepGoing)
            {
                DisplayMenu();

                var choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "B":
                        // int totalChecking = ComputeCheckingBalance(transactions);
                        var totalCheckingDeposits = transactions.Where(transaction => transaction.Account == "Checking" && transaction.Type == "Deposit")
                                                    .Sum(transaction => transaction.Amount);
                        var totalCheckingWithdraw = transactions.Where(transaction => transaction.Account == "Checking" && transaction.Type == "Withdraw")
                                                                .Sum(transaction => transaction.Amount);
                        var totalChecking = totalCheckingDeposits - totalCheckingWithdraw;
                        // var checkingBalance = transactions.
                        // int checkingBalance = 
                        Console.WriteLine("");
                        Console.WriteLine("Checking Account: ${totalChecking}");
                        Console.WriteLine("Savings Account: ${}");
                        break;

                    case "D":
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to deposit funds to your [C]hecking or [S]avings account? ");
                        var depositAccountChoice = Console.ReadLine().ToUpper();

                        if (depositAccountChoice == "C")
                        {
                            var checkingDeposit = new Transaction();

                            Console.WriteLine("");
                            checkingDeposit.Date = DateTime.Now;
                            checkingDeposit.Account = "Checking";
                            checkingDeposit.Type = "Deposit";
                            checkingDeposit.Amount = PromptForInteger("How much would you like to deposit into your checking account? ");
                            Console.WriteLine("");
                            Console.WriteLine($"${checkingDeposit.Amount} has been deposited into your checking account. ");

                            transactions.Add(checkingDeposit);
                        }
                        else if (depositAccountChoice == "S")
                        {
                            var savingsDeposit = new Transaction();

                            Console.WriteLine("");
                            savingsDeposit.Date = DateTime.Now;
                            savingsDeposit.Account = "Savings";
                            savingsDeposit.Type = "Deposit";
                            savingsDeposit.Amount = PromptForInteger("How much would you like to deposit into your savings account? ");
                            Console.WriteLine("");
                            Console.WriteLine($"${savingsDeposit.Amount} has been deposited into your savings account. ");

                            transactions.Add(savingsDeposit);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("");
                            Console.WriteLine("❗That is not a valid selection❗");
                        }
                        break;

                    case "W":
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to withdraw funds from your [C]hecking or [S]avings account? ");
                        var withdrawalAccountChoice = Console.ReadLine().ToUpper();

                        if (withdrawalAccountChoice == "C")
                        {
                            var checkingWithdrawal = new Transaction();

                            Console.WriteLine("");
                            checkingWithdrawal.Date = DateTime.Now;
                            checkingWithdrawal.Account = "Checking";
                            checkingWithdrawal.Type = "Withdrawal";
                            checkingWithdrawal.Amount = PromptForInteger("How much would you like to withdraw from your checking account? ");
                            Console.WriteLine("");
                            Console.WriteLine($"${checkingWithdrawal.Amount} has been withdrawn from your checking account. ");

                            transactions.Add(checkingWithdrawal);
                        }
                        else if (withdrawalAccountChoice == "S")
                        {
                            var savingsWithdrawal = new Transaction();

                            Console.WriteLine("");
                            savingsWithdrawal.Date = DateTime.Now;
                            savingsWithdrawal.Account = "Savings";
                            savingsWithdrawal.Type = "Withdrawal";
                            savingsWithdrawal.Amount = PromptForInteger("How much would you like to withdraw from your savings account? ");
                            Console.WriteLine("");
                            Console.WriteLine($"${savingsWithdrawal.Amount} has been withdrawn from your savings account. ");

                            transactions.Add(savingsWithdrawal);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("");
                            Console.WriteLine("❗That is not a valid selection❗");
                        }
                        break;

                    case "T":
                        break;

                    case "Q":
                        keepGoing = false;
                        break;
                    // VIEW ACCOUNT BALANCES.
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


                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("");
                        Console.WriteLine("❗That is not a valid selection. Try again❗");
                        break;
                }
            }
        }
    }
}
// ALGORITHM
// Load past transactions from csv file.




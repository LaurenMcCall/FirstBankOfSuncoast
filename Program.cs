using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace FirstBankOfSuncoast
{
    class Program
    {
        // public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        // private string FileName = "transaction.csv";
        // static void LoadTransactions(List<Transaction> transactions)
        // {
        //     if (File.Exists("transactions.csv"))
        //     {
        //         var fileReader = new StreamReader("transactions.csv");

        //         var csvReader = new CsvReader(fileReader, CultureInfo.InvariantCulture);

        //         var transactionFile = csvReader.GetRecords<Transaction>().ToList();

        //         fileReader.Close();
        //     }
        // }

        // static void SaveTransactions()
        // {
        //     var fileWriter = new StreamWriter("transactions.csv");

        //     var csvWriter = new CsvWriter(fileWriter, CultureInfo.InvariantCulture);

        //     csvWriter.WriteRecords(transactions);

        //     fileWriter.Close();
        // }

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
            Console.WriteLine("[C]heck Balances");
            Console.WriteLine("[D]eposit Funds");
            Console.WriteLine("[W]ithdraw Funds");
            Console.WriteLine("[V]iew Transaction History");
            Console.WriteLine("[Q]uit");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
        }




        // static void Description(Transaction viewTransactions)
        // {
        //     Console.WriteLine($"{viewTransactions.Date: MM/dd/yyyy} {viewTransactions.Account} {viewTransactions.Type} {viewTransactions.Amount} ");
        // }

        // private int ComputeCheckingBalance(List<Transaction> transactions)
        // {
        //     var totalCheckingDeposits = transactions.Where(transaction => transaction.Account == "Checking" && transaction.Type == "Deposit")
        //                                                         .Sum(transaction => transaction.Amount);
        //     var totalCheckingWithdrawals = transactions.Where(transaction => transaction.Account == "Checking" && transaction.Type == "Withdrawal")
        //                                             .Sum(transaction => transaction.Amount);
        //     var totalChecking = totalCheckingDeposits - totalCheckingWithdrawals;
        //     return totalChecking;
        // }

        static void Main(string[] args)
        {
            var transactions = new List<Transaction>();
            if (File.Exists("transactions.csv"))
            {
                var fileReader = new StreamReader("transactions.csv");

                var csvReader = new CsvReader(fileReader, CultureInfo.InvariantCulture);

                var transactionFile = csvReader.GetRecords<Transaction>().ToList();

                fileReader.Close();
            }
            // LoadTransactions(transactions);

            DisplayGreeting();
            // TEST DATA
            // var testTransaction = new Transaction()
            // {
            //     Date = DateTime.Now,
            //     Amount = 10,
            //     Account = "Checking",
            //     Type = "Deposit"
            // };
            // transactions.Add(testTransaction);
            // var testTransaction1 = new Transaction()
            // {
            //     Date = DateTime.Now,
            //     Amount = 10,
            //     Account = "Savings",
            //     Type = "Deposit"
            // };
            // transactions.Add(testTransaction1);
            // var testTransaction2 = new Transaction()
            // {
            //     Date = DateTime.Now,
            //     Amount = 5,
            //     Account = "Checking",
            //     Type = "Withdrawal"
            // };
            // transactions.Add(testTransaction2);

            var keepGoing = true;

            while (keepGoing)
            {

                DisplayMenu();

                var choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "C":
                        int totalChecking = TotalChecking(transactions);
                        int totalSavings = TotalSavings(transactions);
                        // var checkingBalance = transactions.
                        // int checkingBalance = 
                        // int totalChecking = ComputeCheckingBalance(transactions);
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("ACCOUNT BALANCES:");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Checking Account: ${totalChecking}");
                        Console.WriteLine($"Savings Account: ${totalSavings}");
                        Console.WriteLine("");

                        break;

                    case "D":
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Would you like to deposit funds to your [C]hecking or [S]avings account? ");
                        Console.WriteLine("");
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
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"${checkingDeposit.Amount} has been deposited into your checking account. ");
                            Console.WriteLine("");

                            transactions.Add(checkingDeposit);
                        }
                        else if (depositAccountChoice == "S")
                        {
                            var savingsDeposit = new Transaction();

                            Console.WriteLine("");
                            savingsDeposit.Date = DateTime.Now;
                            savingsDeposit.Account = "Savings";
                            savingsDeposit.Type = "Deposit";
                            Console.ForegroundColor = ConsoleColor.White;
                            savingsDeposit.Amount = PromptForInteger("How much would you like to deposit into your savings account? ");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"${savingsDeposit.Amount} has been deposited into your savings account. ");
                            Console.WriteLine("");

                            transactions.Add(savingsDeposit);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("");
                            Console.WriteLine("❗That is not a valid selection❗");
                        }
                        // SaveTransactions(transactions);
                        break;

                    case "W":
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Would you like to withdraw funds from your [C]hecking or [S]avings account? ");
                        Console.WriteLine("");
                        var withdrawalAccountChoice = Console.ReadLine().ToUpper();

                        if (withdrawalAccountChoice == "C")
                        {
                            var checkingWithdrawal = new Transaction();

                            Console.WriteLine("");
                            checkingWithdrawal.Date = DateTime.Now;
                            checkingWithdrawal.Account = "Checking";
                            checkingWithdrawal.Type = "Withdrawal";
                            Console.ForegroundColor = ConsoleColor.White;
                            checkingWithdrawal.Amount = PromptForInteger("How much would you like to withdraw from your checking account? ");
                            if (checkingWithdrawal.Amount > TotalChecking(transactions))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("");
                                Console.WriteLine("You may not withdraw more than your current balance. ");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"${checkingWithdrawal.Amount} has been withdrawn from your checking account. ");
                                Console.WriteLine("");

                                transactions.Add(checkingWithdrawal);
                            }

                        }
                        else if (withdrawalAccountChoice == "S")
                        {
                            var savingsWithdrawal = new Transaction();

                            Console.WriteLine("");
                            savingsWithdrawal.Date = DateTime.Now;
                            savingsWithdrawal.Account = "Savings";
                            savingsWithdrawal.Type = "Withdrawal";
                            Console.ForegroundColor = ConsoleColor.White;
                            savingsWithdrawal.Amount = PromptForInteger("How much would you like to withdraw from your savings account? ");
                            if (savingsWithdrawal.Amount > TotalSavings(transactions))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("");
                                Console.WriteLine("You may not withdraw more than your current balance. ");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"${savingsWithdrawal.Amount} has been withdrawn from your savings account. ");
                                Console.WriteLine("");

                                transactions.Add(savingsWithdrawal);
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("");
                            Console.WriteLine("❗That is not a valid selection❗");
                        }
                        // SaveTransactions();
                        break;

                    case "V":

                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("TRANSACTION HISTORY: ");

                        foreach (var transaction in transactions)
                        {
                            if (transaction.Type == "Deposit")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("");
                                Console.WriteLine($"{transaction.Date: M/dd/yyyy} {transaction.Type} to {transaction.Account}: ${transaction.Amount} ");
                            }
                            else if (transaction.Type == "Withdrawal")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("");
                                Console.WriteLine($"{transaction.Date: M/dd/yyyy} {transaction.Type} from {transaction.Account}: ${transaction.Amount} ");
                            }
                        }
                        Console.WriteLine("");
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
                var fileWriter = new StreamWriter("transactions.csv");

                var csvWriter = new CsvWriter(fileWriter, CultureInfo.InvariantCulture);

                csvWriter.WriteRecords(transactions);

                fileWriter.Close();
            }
        }

        private static int TotalSavings(List<Transaction> transactions)
        {
            var totalSavingsDeposits = transactions.Where(transaction => transaction.Account == "Savings" && transaction.Type == "Deposit")
                                                                           .Sum(transaction => transaction.Amount);
            var totalSavingsWithdrawals = transactions.Where(transaction => transaction.Account == "Savings" && transaction.Type == "Withdrawal")
                                                      .Sum(transaction => transaction.Amount);
            var totalSavings = totalSavingsDeposits - totalSavingsWithdrawals;
            return totalSavings;
        }

        private static int TotalChecking(List<Transaction> transactions)
        {
            var totalCheckingDeposits = transactions.Where(transaction => transaction.Account == "Checking" && transaction.Type == "Deposit")
                                        .Sum(transaction => transaction.Amount);
            var totalCheckingWithdrawals = transactions.Where(transaction => transaction.Account == "Checking" && transaction.Type == "Withdrawal")
                                                    .Sum(transaction => transaction.Amount);
            var totalChecking = totalCheckingDeposits - totalCheckingWithdrawals;
            return totalChecking;
        }
    }

}
// ALGORITHM
// Load past transactions from csv file.




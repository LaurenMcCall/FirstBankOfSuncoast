using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace FirstBankOfSuncoast
{
    class Transaction
    {
        public DateTime Date { get; set; }
        public string Account { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        //     private string FileName = "transaction.csv";
        //     public void LoadTransactions()
        //     {
        //         if (File.Exists(FileName))
        //         {
        //             var fileReader = new StreamReader(FileName);

        //             var csvReader = new CsvReader(fileReader, CultureInfo.InvariantCulture);

        //             Transactions = csvReader.GetRecords<Transaction>().ToList();

        //             fileReader.Close();
        //         }
        //     }

        //     public void SaveTransactions()
        //     {
        //         var fileWriter = new StreamWriter(FileName);

        //         var csvWriter = new CsvWriter(fileWriter, CultureInfo.InvariantCulture);

        //         csvWriter.WriteRecords(Transactions);

        //         fileWriter.Close();
    }
    // }

}
// }
// ALGORITHM
// Load past transactions from csv file.




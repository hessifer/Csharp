using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WorkingWithClassesObjects
{
    public class BankAccount
    {
        public int Number { get; }
        public string Owner { get; set; }
        public decimal Balnce
        {
            get
            {
                decimal balance = 0;

                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private readonly Random r = new Random();
        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            Number = r.Next(1000, 200000000);
            MakeDeposit(initialBalance, DateTime.Now, "initial deposit");
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive.");
            }

            if (Balnce - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds for this withdrawal.");
            }

            var withdrawal = new Transaction(amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive.");
            }

            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public List<Transaction> GetTransactions()
        {
            return allTransactions;
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            report.AppendLine("Date\t\tAmount\tNote");
            foreach (var transaction in allTransactions)
            {
                // Rows
                report.AppendLine($"{transaction.Date}\t{transaction.Amount}\t{transaction.Notes}");
            }
            return report.ToString();
        }
    }
}

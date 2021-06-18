using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get 
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        private static int accountnumberseed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialbalance) 
        {
            Owner = name;

            MakeDeposit(initialbalance, DateTime.Now, "initial deposit");

            Number = accountnumberseed.ToString();
            accountnumberseed++;
        }


        public void MakeDeposit(decimal amount, DateTime date, string statement) 
        {
            if (amount <= 0) 
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be a positive number");
            }

            var deposit = new Transaction(amount, date, statement);
            allTransactions.Add(deposit);
            

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string statement)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be positive");
            }

            else if (Balance - amount < 0) 
            {
                throw new InvalidOperationException("You dont have enough money to withdraw that amount");
            }

            var withdraw = new Transaction(-amount, date, statement);
            allTransactions.Add(withdraw);


        }

        public string TransactionHistory()
        {
            var report = new StringBuilder();

            report.AppendLine("Date\t\tAmount\tNote");
            foreach (var item in allTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Note}");
            }

            return report.ToString();


        }
    
    }
}

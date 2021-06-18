using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Transaction
    {
        public decimal Amount { get; }

        public DateTime Date { get; }

        public string Note { get; }

        public Transaction(decimal amount, DateTime date, string note) 
        {
            Amount = amount;
            Date = date;
            Note = note;
        }


    }
}

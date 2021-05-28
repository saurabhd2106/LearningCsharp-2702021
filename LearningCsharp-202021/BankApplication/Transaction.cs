using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp_202021.BankApplication
{
    public class Transaction
    {
        public decimal Amount { get; }

        public DateTime DateOfTransaction { get; }

        public string Comments { get; }

        public Transaction(decimal amount, DateTime date, string comments)
        {
            Amount = amount;
            DateOfTransaction = date;
            Comments = comments;
        }

    }
}

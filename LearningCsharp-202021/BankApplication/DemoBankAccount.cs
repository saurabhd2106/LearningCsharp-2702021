using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp_202021.BankApplication
{
    class DemoBankAccount
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Saurabh", 1000);

            Console.WriteLine($"Account - {account.Number} was created for {account.Owner} with Initial Balance as {account.Balance}");

            account.MakeDeposit(3000, DateTime.Now, "Got my salary");

            account.MakeWithdrawal(200, DateTime.Now, "Shopping");

            Console.WriteLine($"Current Balance - {account.Balance}");

            Console.WriteLine(account.GetTransactionStatement());

            var gauravAccount = new BankAccount("Gaurav", 2000);

            Console.WriteLine($"Account - {gauravAccount.Number} was created for {gauravAccount.Owner} with Initial Balance as {gauravAccount.Balance}");
        }
    }
}

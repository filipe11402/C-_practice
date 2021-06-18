using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            var account = new BankAccount("Filipe", 1000);

            Console.WriteLine($"Account: {account.Number} was created for {account.Owner} with {account.Balance}");


            account.MakeWithdrawal(100, DateTime.Now, "Amazon bought F1 shit");
            Console.WriteLine($"Current balance for account n{account.Number} is balance: {account.Balance}");


            //show transactions history form that account
            Console.WriteLine(account.TransactionHistory());


        }
    }
}

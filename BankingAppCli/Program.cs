using System;
using BankingAppLibrary;

namespace BankingAppCli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BankAccount account;
            account = new ChecquingAccount(1, "test", 10000);
            account.Deposit(1000);
            Console.WriteLine(account.CurrentBalance);
            Console.WriteLine(account.WithdrawalLimit);
            account.Withdraw(11000);
            Console.WriteLine(account.CurrentBalance);
            Console.WriteLine(account.WithdrawalLimit);

            //todo: Add a class SavingsAccount
            //todo: Maintain a list of accounts
            //todo: Populate the list with instances of SA/CA based on the choice of the user
            //todo: Observe polymorphic behaviour of the BankAccount by performing transactions om these accounts
        }
    }
}

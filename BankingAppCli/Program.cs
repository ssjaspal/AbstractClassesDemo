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
            account.Withdraw(1000);
            Console.WriteLine(account.CurrentBalance);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BankingAppLibrary
{
    public class ChecquingAccount : BankAccount
    {
        public const float OverdraftLimit = 2500; //const fields are static by default

        public ChecquingAccount(int accountId, string accountHolder, float openingBalance):base(accountId, accountHolder, openingBalance)
        {
                
        }

        /// <summary>
        /// The maximum amount that can be withdrawn from this account
        /// </summary>
        public override float WithdrawalLimit => CurrentBalance + OverdraftLimit; //computed property
        // {
        //     get { return CurrentBalance + OverdraftLimit; }
        // } 

        /// <summary>
        /// Allows withdrawing funds from the account
        /// </summary>
        /// <param name="amount">Amount (CAD) to be withdrawn</param>
        public override void Withdraw(float amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdraw amount must be greater than zero");
            if (amount>WithdrawalLimit)
                //TODO: throw new NotEnoughBalanceException (----);
                throw new ArgumentException("Not enough funds to honor this transaction");
            CurrentBalance -= amount;
        }

    }
}

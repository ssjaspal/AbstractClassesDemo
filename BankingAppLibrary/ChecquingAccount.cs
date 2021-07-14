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
            throw new NotImplementedException("Working on the logic for withdrawal");
        }
    }
}

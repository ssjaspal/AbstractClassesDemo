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


    }
}

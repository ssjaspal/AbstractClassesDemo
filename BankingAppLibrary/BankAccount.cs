using System;

namespace BankingAppLibrary
{
    public abstract class BankAccount
    {
        private int _accountId;
        private string _accountHolder;
        private float _currentBalance;

        /// <summary>
        /// Initializes state of a Bank BankAccount
        /// </summary>
        /// <param name="accountId">Unique identifier for each account</param>
        /// <param name="accountHolder">The name of the account holder</param>
        /// <param name="openingBalance">The initial amount deposited while opening the account</param>
        protected BankAccount(int accountId, string accountHolder, float openingBalance)
        {
            AccountId = accountId;
            AccountHolder = accountHolder;
            Deposit(openingBalance);
        }

        /// <summary>
        /// Unique identifier for each bank account
        /// </summary>
        public int AccountId
        {
            get => _accountId;
            private set => _accountId = value;
        }

        /// <summary>
        /// The name of the account holder
        /// </summary>
        public string AccountHolder
        {
            get => _accountHolder;
            private set => _accountHolder = value;
        }

        /// <summary>
        /// Current balance in the account
        /// </summary>
        public float CurrentBalance
        {
            get => _currentBalance;
            protected set => _currentBalance = value;
        }


        /// <summary>
        /// Allows depositing funds in the account
        /// </summary>
        /// <param name="amount">Amount (CAD) to be deposited</param>
        public void Deposit(float amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be greater than zero");
            CurrentBalance += amount;
        }

        /// <summary>
        /// Allows withdrawing funds from the account
        /// </summary>
        /// <param name="amount">Amount (CAD) to be withdrawn</param>
        public abstract void Withdraw(float amount);
    }
}

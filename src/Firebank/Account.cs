using System;

namespace Firebank
{
    public class Account
    {
        internal string Name { get; set; }
        internal string AccountOwner { get; set; }
        internal string IBAN { get; set; }
        internal decimal Balance { get; set; }
        internal int ID { get; set; }
        public Account(int ID, int AccountOwner, string IBAN, decimal Balance, string AccountName)
        {
            this.ID = ID;
            this.AccountOwner = AccountOwner.ToString();
            this.IBAN = IBAN;
            this.Balance = Balance;
            this.Name = AccountName;
        }
    }
}
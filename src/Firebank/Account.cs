using System;

namespace Firebank
{
    public class Account
    {
        internal string Name { get; set; }
        internal string AccountOwner { get; set; }
        internal string IBan { get; set; }
        internal decimal Balance { get; set; }
        internal int ID { get; set; }
        public Account(int ID, int AccountOwner, string IBan, decimal Balance, string AccountName)
        {
            this.ID = ID;
            this.AccountOwner = AccountOwner.ToString();
            this.IBan = IBan;
            this.Balance = Balance;
            this.Name = AccountName;
        }
    }
}
namespace Firebank
{
    public class Account
    {
        internal string Name { get; set; }
        internal string AccountOwner { get; set; }
        internal string IBan { get; set; }
        internal string Balance { get; set; }
        internal int ID { get; set; }
        public Account(int ID, int AccountOwner, string IBan, int Balance, string AccountName)
        {
            this.ID = ID;
            this.AccountOwner = AccountOwner.ToString();
            this.IBan = IBan;
            this.Balance = Balance.ToString();
            this.Name = AccountName;
        }
    }
}
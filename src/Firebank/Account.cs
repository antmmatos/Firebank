namespace Firebank
{
    internal class Account
    {
        internal string Name { get; set; }
        internal string AccountOwner { get; set; }
        internal string IBan { get; set; }
        internal string Balance { get; set; }
        internal int ID { get; set; }
        internal int Index { get; set; }
        public Account(int ID, int AccountOwner, string IBan, int Balance, string AccountName, int Index)
        {
            this.ID = ID;
            this.AccountOwner = AccountOwner.ToString();
            this.IBan = IBan;
            this.Balance = Balance.ToString();
            this.Name = AccountName;
            this.Index = Index;
        }
    }
}
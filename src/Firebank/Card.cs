using System;

namespace Firebank
{
    public class Card
    {
        internal int ID { get; set; }
        internal string CardNumber { get; set; }
        internal DateTime CardExpireDate { get; set; }
        internal string CardCVV { get; set; }
        internal int AccountID { get; set; }
        internal bool isActivated { get; set; }
        internal bool isFreeze { get; set; }
        internal bool isActivating { get; set; }
        public Card(int ID, string CardNumber, DateTime CardExpireDate, string CardCVV, int AccountID, bool isActivated, bool isFreeze, bool isActivating)
        {
            this.ID = ID;
            this.CardNumber = CardNumber;
            this.CardExpireDate = CardExpireDate;
            this.CardCVV = CardCVV;
            this.AccountID = AccountID;
            this.isActivated = isActivated;
            this.isFreeze = isFreeze;
            this.isActivating = isActivating;
        }
    }
}
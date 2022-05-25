using System;
using System.Collections.Generic;
using System.Text;

namespace WiredTransactionAuthorizationSystem
{
    public class foreignTransactionDecor: TransactionDecor
    {
        public foreignTransactionDecor(ITransaction transaction) : base(transaction) { }

        public override string GetName()
        {
            return base.GetName() + " making transaction with an account from foreign bank for 1 year.";
        }
        public override float GetFee()
        {
            return base.GetFee() + 25;
        }
    }
}

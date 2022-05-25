using System;
using System.Collections.Generic;
using System.Text;

namespace WiredTransactionAuthorizationSystem
{
    public class OwnTransactionDecor:TransactionDecor
    {
        public OwnTransactionDecor(ITransaction transaction) : base(transaction) { }

        public override string GetName()
        {
            return base.GetName() + " making own transaction inner accounts, meaning savings and current account for 1 year.";
        }
        public override float GetFee()
        {
            return base.GetFee() + 17;
        }
    }
}

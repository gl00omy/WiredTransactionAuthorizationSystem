using System;
using System.Collections.Generic;
using System.Text;

namespace WiredTransactionAuthorizationSystem
{
    public class sameTransactionDecor:TransactionDecor
    {
        public sameTransactionDecor(ITransaction transaction) : base(transaction) { }

        public override string GetName()
        {
            return base.GetName() + " making transaction with another account on the same bank for 1 year.";
        }
        public override float GetFee()
        {
            return base.GetFee() + 5;
        }
    }
}

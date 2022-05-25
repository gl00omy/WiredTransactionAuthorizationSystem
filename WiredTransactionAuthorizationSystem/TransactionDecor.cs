using System;
using System.Collections.Generic;
using System.Text;

namespace WiredTransactionAuthorizationSystem
{
    public class TransactionDecor :ITransaction
    {
        private readonly ITransaction transaction;

        public TransactionDecor(ITransaction transaction)
        {
            this.transaction = transaction;
        }
        public virtual string GetName()
        {
            return transaction.GetName();
        }

        public virtual float GetFee()
        {
            return transaction.GetFee();
        }
    }
}

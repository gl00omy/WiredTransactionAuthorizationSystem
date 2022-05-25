using System;
using System.Collections.Generic;
using System.Text;

namespace WiredTransactionAuthorizationSystem
{
    public interface ITransaction
    {
        string GetName();
        float GetFee();
    }
}

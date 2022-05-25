using System;
using System.Collections.Generic;
using System.Text;

namespace WiredTransactionAuthorizationSystem
{
    public class CorporateAccount : ITransaction
    {
        public string GetName()
        {
            return "Account for use in work between companies.";
        }
        public float GetFee()
        {
            return 70;
        }

    }
}

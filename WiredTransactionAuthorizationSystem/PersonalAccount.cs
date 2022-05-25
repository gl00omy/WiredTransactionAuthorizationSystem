using System;
using System.Collections.Generic;
using System.Text;

namespace WiredTransactionAuthorizationSystem
{
    public class PersonalAccount:ITransaction
    {
        public string GetName()
        {
            return "Account for personal use, includes tax paying and insurance.";
        }
        public float GetFee()
        {
            return 50;
        }
        
    }
}

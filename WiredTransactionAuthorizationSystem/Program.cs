using System;

namespace WiredTransactionAuthorizationSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dear user!!! Here is our current tariffs");
            ITransaction personal = new PersonalAccount();

            ITransaction foreign = new foreignTransactionDecor(personal);
            Console.WriteLine($"Tariff description: {foreign.GetName()}, monthly fee: {foreign.GetFee()}");


            ITransaction corporate = new CorporateAccount();
            ITransaction same = new sameTransactionDecor(corporate);
            Console.WriteLine($"Tariff description: {same.GetName()}, monthly fee: {same.GetFee()}");
        }
    }
}

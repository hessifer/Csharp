using System;

namespace WorkingWithClassesObjects
{
    class Program
    {
        static void Main()
        {
            var myAccount = new BankAccount("Charles A. Hessifer", (decimal)1204.33);

            // Display the account id and balance of my account
            Console.WriteLine($"Account Number: {myAccount.Number}");
            Console.WriteLine($"Account Balance: {myAccount.Balnce:C}");

            // Make a deposit in our account
            DateTime date = DateTime.Now;
            try
            {
                myAccount.MakeDeposit((decimal)111.00, date, "Money from Twitch");

                // Display our balance after the deposit
                Console.WriteLine($"Account Balance: {myAccount.Balnce:C}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"ERROR: {e}");
            }

            // Get Account Transaction History
            Console.WriteLine($"\n\n{myAccount.GetAccountHistory()}");
        }
    }
}

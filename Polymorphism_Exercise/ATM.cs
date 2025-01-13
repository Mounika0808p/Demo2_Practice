using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Exercise
{


                           // ATM class for method overloading
    public class ATM
    {
        // Withdraw method 
        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Withdrawal of {amount} from default account");
        }

        // Withdraw method: Specifying amount and account type
        public void Withdraw(decimal amount, string accountType)
        {
            Console.WriteLine($"Withdrawal of {amount} from {accountType} account");
        }

        // Withdraw method: Specify amount, account type, and currency
        public void Withdraw(decimal amount, string accountType, string currency)
        {
            Console.WriteLine($"Withdrawal of {amount} {currency} from {accountType} account");
        }
    }
}




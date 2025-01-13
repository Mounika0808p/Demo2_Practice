using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Exercise
{

                                 // Paymentsystem class for method overriding
    public class PaymentSysyem
    {
        // Virtual method 
        public virtual void Payment(decimal amount)
        {
            Console.WriteLine($"Processing a payment of {amount}");
        }
    }

    public class CreditCardPayment : PaymentSysyem
    {
        // Override method
        public override void Payment(decimal amount)
        {
            Console.WriteLine($"Processing a Credit Card payment of {amount}");
        }
    }

    public class PayPalPayment : PaymentSysyem
    {
        // Override method
        public override void Payment(decimal amount)
        {
            Console.WriteLine($"Processing a PayPal payment of {amount}");
        }
    }




}


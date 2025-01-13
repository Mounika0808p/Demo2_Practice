// See https://aka.ms/new-console-template for more information
using System;


namespace Polymorphism_Exercise
{

    public class Program
    {
        public static void Main(string[] args)
        {
           
            // Method overloading

            ATM atm = new ATM();
            Console.WriteLine("Displaying withdrawal types");
            atm.Withdraw(500.00m);                              
            atm.Withdraw(1000.00m, "Checking");                   
            atm.Withdraw(200.00m, "Savings", "USD");

            Console.WriteLine();







            // Method overriding
            
            Console.WriteLine("Displaying diffrent card payments");
            PaymentSysyem payment = new CreditCardPayment();
            
            payment.Payment(100.00m);
            
            PaymentSysyem payment1 = new PayPalPayment();
            payment1.Payment(200.00m);

        }
    }
}




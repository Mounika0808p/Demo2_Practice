// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Threading.Channels;

namespace Encapsulation_Exercise
{

    class BankAccount
    {
        // private field 
        private double balance; 

        //public property 
        public double Balance
        {
            get 
            {
                return balance;
            }
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine($"Deposit Successful New Balance is : {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance =balance - amount;
                Console.WriteLine($"Withdrawal Successful New Balance is : {balance}");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount();

            Console.WriteLine("Welcome to the Bank Account System");
            bool condition;

            while (condition = true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                

                switch (choice)
                {
                    case "1": // Check Balance
                        Console.WriteLine($"Your current balance is : {account.Balance}");
                        break;

                    case "2": // Deposit
                        Console.Write("Enter the amount to deposit: ");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            account.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a numeric value.");
                        }
                        break;

                    case "3": // Withdraw
                        Console.Write("Enter the amount to withdraw: ");
                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                        {
                            account.Withdraw(withdrawAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a numeric value.");
                        }
                        break;

                    case "4": // Exit
                        Console.WriteLine("Thank you for using the Bank Account System. Goodbye!");
                        condition = false;
                        break;

                    default: // Invalid Option
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
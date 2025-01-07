// See https://aka.ms/new-console-template for more information
using System;
using ConstWithAccessmodifiers_Exercise;

namespace Demo2.Practice
{

    public class Product
    {
        // Properties
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public static string CompanyName { get; set; }

        // Static Constructor 
        static Product()
        {
            CompanyName = "Global Tech Products";
            Console.WriteLine("Static Constructor initialized");
        }

        // Public Constructor
        public Product(int productID, string name, double price)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            Console.WriteLine("Public Constructor");
        }

        // Private Constructor 
        private Product(int productID)
        {
            ProductID = productID;
            Name = "Default Product";
            Price = 0.0;
            Console.WriteLine("Private Constructor");
        }


        //  Method for Private Constructor
        public static Product CreateDefaultProduct(int productID)
        {
            return new Product(productID);
        }

        // Protected Constructor
        protected Product(string name)
        {
            ProductID = 103; 
            Name = name;
            Price = 50.0; 
            Console.WriteLine("Protected Constructor");
        }

        // Internal Constructor 
        internal Product(double price)
        {
            ProductID = 104; 
            Name = "Watch";
            Price = price;
            Console.WriteLine("Internal Constructor");
        }
        // Protected internal constructor
        protected internal Product(string name, double price)
        {
            ProductID = 105; 
            Name = name;
            Price = price;
            Console.WriteLine("Protected Internal Constructor");
        }



        // Display Product Details
        public void DisplayDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Company: {CompanyName}\n");
        }
    }

 
   

    class Program
    {
        static void Main()
        {
           //static
            Console.WriteLine("Accessing static fields");
            Console.WriteLine($"Company Name: {Product.CompanyName}\n");

            //public
            var publicProduct = new Product(101, "Laptop", 1500.0);
            publicProduct.DisplayDetails();

            // private
            var Productmethod = Product.CreateDefaultProduct(102);
            Productmethod.DisplayDetails();

            //Protected using Derived Class
            var electronicsProduct = new Electronics("Smartphone");
            electronicsProduct.DisplayDetails();

            //Internal
            var internalProduct = new Product(200.0);
            internalProduct.DisplayDetails();

            //Protected Internal 
            var specialProduct = new Product("New IPhone", 5000.0);
            specialProduct.DisplayDetails();

            
        }
    }
}
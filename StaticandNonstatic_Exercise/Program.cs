// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http.Headers;

namespace Demo2_Practice
{
    class StaticandNonstatic
    {

        // static field 

        public static int totalproducts = 0;

        // static method

        public static void Displaytotalproducts()
        {
            Console.WriteLine("Total products = "+totalproducts);
        }
        // non-static field

        public string Name;
        public double Price;

        // non-static method 

        public void Products()
        {
            Console.WriteLine("Product name = "+Name);
            Console.WriteLine("Product price = " + Price);
            totalproducts++;
        }
        static void Main(string[] args)
        {
            
            StaticandNonstatic s1 = new StaticandNonstatic();
            s1.Name = "Laptop";
            s1.Price = 99000;
            StaticandNonstatic s2 = new StaticandNonstatic();
            s2.Name = "Smartphone";
            s2.Price = 50000;
           
            s1.Products();
            s2.Products();
            StaticandNonstatic.Displaytotalproducts();



        }
    }
}

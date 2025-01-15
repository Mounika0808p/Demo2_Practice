// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Diagnostics;
using System.Xml.Linq;

namespace Arrays_Execise
{

    class Product : IComparable<Product>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public int CompareTo(Product other)
        {
            if (other == null) return 1;
            return this.ID.CompareTo(other.ID);
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Category: {Category}, Price: {Price}";
        }
    }


    class ProductInventory
    {
        static void Main()
        {

            // Array

            string[] productnumber = new string[4];

            productnumber[0] = "Electronics";
            productnumber[1] = "Groceries";
            productnumber[2] = "Clothing";
            productnumber[3] = "Stationery";


            Console.WriteLine("Product Categories ");
            foreach (var category in productnumber)
            {
                Console.WriteLine($"Category: {category}");
            }

            // ArrayList 
           List<Product> productDetails = new List<Product>();

            productDetails.Add(new Product { ID = 1, Name = "Smartphone", Category = "Electronics", Price = 699.99 });
            productDetails.Add(new Product { ID = 2, Name = "Ricebag 10kg", Category = "Groceries", Price = 12.50 });
            productDetails.Add(new Product { ID = 3, Name = "T-shirt", Category = "Clothing", Price = 19.99 });
            productDetails.Add(new Product { ID = 4, Name = "Notebook", Category = "Stationery", Price = 2.49 });
            productDetails.Add(new Product { ID = 5, Name = "AC", Category = "Electronics", Price = 49.99 });



            #region Display product details

            Console.WriteLine("\nProduct Details ");
            foreach (Product product in productDetails)
            {
                Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Category: {product.Category}, Price: ${product.Price}");
            }
            #endregion


            #region Removeing one product
            productDetails.RemoveAt(2);

            Console.WriteLine("\nProduct Details after removing one product");

            foreach (Product product in productDetails)
            {
                Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Category: {product.Category}, Price: ${product.Price}");
            }
            #endregion


            #region Reversing all products
            productDetails.Reverse();

            Console.WriteLine("\nProduct details after reversing");

            foreach (Product product in productDetails)
            {
                Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Category: {product.Category}, Price: ${product.Price}");
            }
            #endregion


            #region AddRange
            Product product5 = new Product { ID = 6, Name = "Headphones", Category = "Electronics", Price = 49.99 };
            // productDetails.AddRange(Product5);
            Console.WriteLine("displaying product rangeing");

            foreach (Product product in productDetails)
            {
                Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Category: {product.Category}, Price: ${product.Price}");
            }
            #endregion


            #region Contains

            // pd p = new pd { ID = 6, Name = "Sofa", Category = "Furniture", Price = 250.00 };


            Console.WriteLine("\nDisplaying one product having it or not ");

            var list = productDetails.Where(x => x.Name.Contains("TV"));

            if (!list.Any())
            {
                Product p = new Product { ID = 6, Name = "TV", Category = "Electronics", Price = 250.00 };
                productDetails.Add(p);
                Console.WriteLine("Product added successfully");
            }
            else
                
            {
                Console.WriteLine("Checking items after sorted with AC");
                foreach (Product product in productDetails)
                {
                    Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Category: {product.Category}, Price: ${product.Price}");


                }
            }
            var Checking = productDetails.Where(x => x.Name.Contains("AC"));
            Console.WriteLine("Testing");



            //else
            //{
            //    Console.WriteLine("No such product");
            //}


            #endregion

            #region Sorting product details

            // productDetails.Sort();
            Console.WriteLine("\nDisplaying products in sorting order ");

            foreach (Product product in productDetails)
            {
                Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Category: {product.Category}, Price: ${product.Price}");


            }
            #endregion


        }
    }




}


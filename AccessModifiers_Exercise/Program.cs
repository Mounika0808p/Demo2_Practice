// See https://aka.ms/new-console-template for more information
using System;
using AccessModifiers_Exercise;

namespace Demo2_Practice
{

    internal class Vehicle
    {
       
        public string Brand { get; set; } 
        private string EngineNumber { get; set; }
        protected int MaxSpeed { get; set; }
        internal string LicensePlate { get; set; }
        protected internal string FuelType { get; set; }

    
        // Constructor
        public Vehicle()
        {
            EngineNumber = "ENG12345"; 
            MaxSpeed = 180;            
           
        }

        // method 
        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"Engine Number: {EngineNumber}"); 
            Console.WriteLine($"License Plate: {LicensePlate}"); 
            Console.WriteLine($"Fuel Type: {FuelType}");         
            
        }
    }


    // Another class in the same assembly
    class Program
    {
        static void Main()
        {
            
            Vehicle vehicle = new Vehicle();
            vehicle.Brand = "Tesla";               
            vehicle.LicensePlate = "XYZ1234";       
            vehicle.FuelType = "Electric";         
            // vehicle.MaxSpeed = 200;            
                                                
           
            vehicle.DisplayVehicleDetails();

            
            Derivedclass der = new Derivedclass();
            der.Brand = "BMW";
            der.DisplayderivedclassDetails();
        }
    }
}



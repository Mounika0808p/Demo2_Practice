using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Demo2_Practice;
using Microsoft.VisualBasic.FileIO;

namespace AccessModifiers_Exercise
{
    internal class Derivedclass : Vehicle
    {

       
            public void DisplayderivedclassDetails()
            {
                Console.WriteLine($"Brand: {Brand}");       
                Console.WriteLine($"Max Speed: {MaxSpeed}"); 
                Console.WriteLine($"Fuel Type: {FuelType}"); 
                                                 
            }

    }
}

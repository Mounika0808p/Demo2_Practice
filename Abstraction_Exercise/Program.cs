// See https://aka.ms/new-console-template for more information
using System;


namespace Abstraction_Exercise
{

    abstract class Shape
    {
         // absrtact method
        public abstract double CalculateArea();

        // Normal method 
        public void DisplayShapeInfo()
        {
            Console.WriteLine("This is a shape ");
        }
    }

    class Circle : Shape
    {
        private double radius; 
        public double Radius
        {
            get 
            {
                return radius;
            }
            set
            {
                if (value > 0)
                    radius = value;
                else
                    Console.WriteLine("Radius must be greater than zero.");
            }
        }
        // constructor
        public Circle(double radius)
        {
            Radius = radius; 
        }
        public override double CalculateArea()
        {
            return radius * 2; 
        }
    }

    class Rectangle : Shape
    {
        private double length; 
        private double width;  
        
        //public property for length
        public double Length
        {
            get 
            {
                return length; 
            }
            set
            {
                if (value > 0)
                    length = value;
                else
                    Console.WriteLine("Length must be greater than zero.");
            }
        }

        // Public property for width 
        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                    width = value;
                else
                    Console.WriteLine("Width must be greater than zero.");
            }
        }

        // Constructor 
        public Rectangle(double length, double width)
        {
            Length = length; 
            Width = width;   
        }

        public override double CalculateArea()
        {
            return length * width; 
        }
    }

    class Program
    {
        static void Main()
        {
            // circle object
            Circle circle = new Circle(5); 
            circle.DisplayShapeInfo();
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

            // rectangle object
            Rectangle rectangle = new Rectangle(4, 6); 
            rectangle.DisplayShapeInfo();
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");

            //invalid inputs
            Console.WriteLine(" invalid inputs ");
            circle.Radius = -10; 
            rectangle.Length = -5; 
            rectangle.Width = -3;  
        }
    }

}

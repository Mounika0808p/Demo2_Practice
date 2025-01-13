using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Exercise
{
    internal class Employee
    {

        private int id;
        private string name;
        private double salary;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {

                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    Console.WriteLine("Value should not be zero");
                }
            }
        }
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {

                if (String.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty");
                }
            }
        }
        public double Salary 
        {
            get
            {
                return salary;
            }
            set
            {

                if (value > 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Value should not be zero");
                }
            }
        }

        public void empDetails()
        {
            Console.WriteLine($"Id = {id} , Name = {name} , Salary = {salary}");
        }


    }

    class Mainprogram
    {

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 1;
            emp.Name = "Mounika";
            emp.Salary = 1000000;
            emp.empDetails();

        }
    }
}

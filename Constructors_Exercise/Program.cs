// See https://aka.ms/new-console-template for more information
using System;

namespace Demo2_Practice
{

    class Student
    {
        
        public int StudentID { get;  set; }
        public string Name { get;  set; }
        public int Age { get;  set; }
        public double GPA { get;  set; }
        public static string SchoolName { get;  set; }
       

        // Static Constructor 
        static Student()
        {
            SchoolName = "Rutland High School";
            Console.WriteLine("Static Constructor: School name initialized.");
        }

        // Default Constructor
        public Student()
        {
            StudentID = 0;
            Name = "Unknown";
            Age = 0;
            GPA = 0.0;
            Console.WriteLine("Default Constructor: Student created with default values.");
        }

        // Parameterized Constructor
        public Student(int studentID, string name, int age, double gpa)
        {
            StudentID = studentID;
            Name = name;
            Age = age;
            GPA = gpa;
            Console.WriteLine($"Parameterized Constructor: Student {Name} created with ID {StudentID}.");
        }

      

        // Copy Constructor
        public Student(Student copyStudentdetails)
        {
            StudentID = copyStudentdetails.StudentID;
            Name = copyStudentdetails.Name;
            Age = copyStudentdetails.Age;
            GPA = copyStudentdetails.GPA;
            Console.WriteLine("Copy Constructor: Student record copied.");
        }

        // Private Constructor
        private Student(int studentID, string name)
        {
            StudentID = studentID;
            Name = name;
            Age = 18;
            GPA = 2.8;
            Console.WriteLine("Private constructor : Student created");

        }

        // Method for accesing private constructor
        public static Student CreateStudent(int studentID, string name)
        {
            return new Student(studentID, name);
        }

        // singleton 

        //public static GetSingletonInstance()
        //{
        //    if (GetSingletonInstance == null)
        //    {
        //        GetSingletonInstance = new Student(0, "Singleton instance");
        //        Console.WriteLine();

        //    }
        //}


        // Regular Method
        public void DisplayDetails()
        {
            Console.WriteLine($"Student ID: {StudentID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"GPA: {GPA}");
            Console.WriteLine($"School: {SchoolName}\n");
        }
    }

    class Program
    {
        static void Main()
        {
            // 1. Default Constructor
            var defaultStudent = new Student();
            defaultStudent.DisplayDetails();

            // 2. Parameterized Constructor
            var parameterizedStudent = new Student(1234, "Johmika", 20, 3.8);
            parameterizedStudent.DisplayDetails();

           
            // 4. Copy Constructor
            var copiedStudent = new Student(parameterizedStudent);
            copiedStudent.DisplayDetails();

            // 5. Private Constructor
            var privatestudent = Student.CreateStudent(104, "Advaitha");
            privatestudent.DisplayDetails();

           
        }
    }
}
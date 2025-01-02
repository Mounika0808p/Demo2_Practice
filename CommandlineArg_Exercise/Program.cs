// See https://aka.ms/new-console-template for more information
using System;

namespace Demo2_Practice
{
    class CommandlineArg
    {
        // Const readonly program

        public const string name = "Mounika";
        
        public readonly DateTime Starttime;

        // Constructor
        public CommandlineArg()
        {
            Starttime = DateTime.Now;
        }

        public void Displayinfo()
        {
            Console.WriteLine($" App Name :{name}");
            Console.WriteLine($"Start time :{Starttime}");
        }

        static void Main(string[] args)
        {

            CommandlineArg cmd = new CommandlineArg();
            cmd.Displayinfo();
            Console.WriteLine();





            // Command line arguments program
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide your name to greet : ");
            }
            else
            {
                string name = args[0];
                Console.WriteLine($"Hello, {name}");
            }



        }
    }
}

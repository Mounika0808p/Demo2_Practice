using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo2.Practice;

namespace ConstWithAccessmodifiers_Exercise
{
    public class Electronics : Product
    {

        public Electronics(string name) : base(name)
        {
            Console.WriteLine("Derived Class Constructor which is protected");
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterface
{
     class Person
    {
        static Person()
        {
            Console.WriteLine("static contructor working ");
        }
        public Person()
        {
            Console.WriteLine("non static constructor working");
        }
        public static int Age { get; set; }

        public static void ShowText()
        {
            Console.WriteLine("Text");
        }
    }
}

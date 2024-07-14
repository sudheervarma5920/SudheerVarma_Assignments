using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class program8
    {
        static void Main()
        {
            Console.WriteLine("enter the number");
            long num = long.Parse(Console.ReadLine());
            long fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"factorial of {num} : {fact}");
        }
    }
}


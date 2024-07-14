using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers");
            int num1 = int.Parse(Console.ReadLine()); //8
            int num2 = int.Parse(Console.ReadLine());//4

            for(int i = num1; i <= num2; i++)
            {
                Console.WriteLine(i);

            }


        }
    }
}

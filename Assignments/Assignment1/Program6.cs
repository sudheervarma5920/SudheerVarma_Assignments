using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program6

    {
        static void Main()
        {
            Console.Write("Enter temp in farenheit:");
            float temp = Convert.ToSingle(Console.ReadLine());
            float fnh = (temp - 32) * 5 / 9;
            Console.WriteLine("temperature in celcius: " + fnh);
        }
    }
}

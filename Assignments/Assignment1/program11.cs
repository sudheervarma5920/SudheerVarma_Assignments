using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class program11
    {
        static void Main()
        {
            Console.Write("Enter no:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(n + "*" + i + "=" + n * i);
            }
        }
    }
}

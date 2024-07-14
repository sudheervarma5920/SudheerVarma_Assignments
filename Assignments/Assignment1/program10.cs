using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class program10
    {
        static void Main()
        {
            Console.Write("Enter a No:");
            int n = int.Parse(Console.ReadLine());
            int soc = 0;
            for (int i = 0; i <= n; i++)
            {
                soc += i * i * i;
            }
            Console.WriteLine(soc);
        }
    }
}

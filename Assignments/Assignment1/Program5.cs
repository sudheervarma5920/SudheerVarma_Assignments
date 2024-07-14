using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program5
    {
        static void Main()
        {

            Console.WriteLine("enter array size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"enetr a[{i}]");

                arr[i] = int.Parse(Console.ReadLine());
            }
            int evencount = 0, oddcount = 0;
            foreach (int i in arr)
            {
                if (i % 2 != 0)
                {
                    oddcount++;
                }
                else
                {
                    evencount++;
                }
            }

            Console.WriteLine($"Total even numbers accepted by the user : {evencount}\nTotal odd numbers accepted by the user :{oddcount}");


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class program14
    {
        static void Main()
        {

            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("enter " + i + " value: ");

                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Array.Sort(arr);
            Console.WriteLine(arr[0]);
        }
    }

}


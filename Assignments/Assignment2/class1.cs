using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Class1
    {
        public static void Main()
        {

            double amt = 915.00;
            Console.Write("Enter payment:");

            double paid = double.Parse(Console.ReadLine());
            int i = 1;
            while (amt >= 0)
            {
                Console.WriteLine($"Month = {i} Balance = {amt} total payments = {paid * i}");
                amt = Balance(amt) - paid;
                i++;
            }
            double Balance(double balance)
            {
                balance = ((balance + (balance * 0.015)));
                return balance;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class program17
    {
        static void Main()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            for (int i = word.Length - 1; i > -1; i--)
            {
                Console.Write(word[i]);
            }
        }
    }
}
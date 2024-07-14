using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class program19
    {
        static void Main()
        {
            Console.WriteLine("enter the word");
            string word = Console.ReadLine();
            int t = 0;
            for (int i = 0, j = word.Length - 1; i < j; i++, j--)
            {
                if (word[i] != word[j])
                {

                    t++;
                }

            }

            if (t == 0)
            {
                Console.WriteLine("word is polindrome");
            }
            else
            {
                Console.WriteLine("word is not polindrome");

            }


        }
    }
}

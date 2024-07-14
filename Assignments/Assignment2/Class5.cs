using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Class5
    {
        int RollNo;
        string StudName;
        int MarksInEng;
        int MarksInMaths;
        int MarksInScience;
        Class5(int RollNo, string StudName, int MarksInEng, int MarksInMaths, int MarksInScience)
        {
            this.RollNo = RollNo;
            this.StudName = StudName;
            this.MarksInEng = MarksInEng;
            this.MarksInMaths = MarksInMaths;
            this.MarksInScience = MarksInScience;
        }
        void display()
        {
            Console.WriteLine(this.RollNo);
            Console.WriteLine(this.StudName);
            int total = this.MarksInScience + this.MarksInEng + this.MarksInMaths;
            Console.WriteLine("Total marks " + total);
            double per = (total * 100) / 300;
            Console.WriteLine($"Percentage of {this.StudName} is {per}%");


        }
        static void Main()
        {
            Class5 s1 = new Class5(105, "sudheer", 65, 70, 83);
            s1.display();
        }
    }
}
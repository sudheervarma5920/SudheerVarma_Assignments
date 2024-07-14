using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace assignment3
{
    internal class Building

    {
        public string type;
        public string capacity;
        public string dimension;
        public DateTime dateofcomplestion;

        public Building(string type, string capacity, string dimension, DateTime dateofcDomplestin)
        {
            this.type = type;
            this.capacity = capacity;
            this.dimension = dimension;
            this.dateofcomplestion = dateofcomplestion;

        }

        
        public void ShowData()
        {
            Console.WriteLine($"type :{this.type}");
            Console.WriteLine($"capacity:{this.capacity}");
            Console.WriteLine($"dimention:{this.dimension}");
            Console.WriteLine($"dateofcompeny:{this.dateofcomplestion} ");





        }
        
            public static void Main(string[] args)
            {


                Console.WriteLine("Enter type");
                String type = Console.ReadLine();
            Console.WriteLine("Enter capacity");
            String capacity = Console.ReadLine();

                String dimension = "";

                if(type == "Villa")
                {
                    Console.WriteLine("Enter dimension of villa");
                    dimension = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Enter floor of flat");
                    dimension = Console.ReadLine();

                }

                Building b = new Building(type,capacity,dimension, DateTime.Parse("05-09-2025"));
                b.ShowData();

                




            }
        }




    }


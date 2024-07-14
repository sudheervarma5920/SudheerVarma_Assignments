
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Furniture
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string FurnitureType { get; set; }
        public int Qty { get; set; }
        public double TotalAmt { get; set; }
        public string PaymentMode { get; set; }

        
    }
    public class Chair : Furniture
    {

        public string ChairType { get; set; }
        public string purpose { get; set; }
        public string WoodType { get; set; }
        public string SteelType { get; set; }
        public string PlasticColor { get; set; }
        public double Rate { get; set; }

        public void getData()
        {
            Console.Write("Enter Id: ");
            OrderId = int.Parse(Console.ReadLine());
            Console.Write("Enter Date YYYY-MM-DD: ");
            OrderDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            Qty = int.Parse(Console.ReadLine());
            Console.Write("Enter Amount: ");
            TotalAmt = int.Parse(Console.ReadLine());
            Console.Write("Payment Mode (Credit/Debit): ");
            PaymentMode = (Console.ReadLine());
           
            Console.WriteLine("Purpose (Home/Office): ");
            purpose = Console.ReadLine();
            Console.WriteLine("Enter Chair Type (Wood/Steel/Plastic): ");
            ChairType = Console.ReadLine();
            if (ChairType == "Wood")
            {
                Console.WriteLine("Choose wood Type (Wood/Rose): ");
                WoodType = Console.ReadLine();
            }
            else if (ChairType == "Steel")
            {
                Console.WriteLine("Choose Steel Type (Grey steel/Green steel/Brown Steel): ");
                SteelType = Console.ReadLine();
            }
            else if (ChairType == "Plastic")
            {
                Console.WriteLine("Choose Plastic Color (Green/Red/Blue/White): ");
                PlasticColor = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.WriteLine("Enter Rate: ");
            Rate = double.Parse(Console.ReadLine());
        }
        public void ShowData()
        {
            Console.Write($"Id: {OrderId}\nDate: {OrderDate}");
            if (FurnitureType == null)
            {
                Console.Write("\n");
            }
            else
            {
                Console.WriteLine($"Furniture Type: {FurnitureType}");
            }
            Console.WriteLine($"Quantity: {Qty}");
            Console.WriteLine($"Total Amount: {TotalAmt}");
            Console.WriteLine($"Payment Mode: {PaymentMode}");
            Console.Write($"ChairType: {ChairType}\npurpose: {purpose}");
            if (ChairType == "Wood")
            {
                Console.WriteLine($"Wood Type: {WoodType}");
            }
            else if (ChairType == "Steel")
            {
                Console.WriteLine($"Steel Type: {SteelType}");
            }
            else
            {
                Console.WriteLine($"Plastic Color: {PlasticColor}");
            }


            Console.WriteLine($"Rate: {Rate}");
        }
    }
    public class Cot : Furniture
    {
        public string CotType { get; set; }
        public int capacity { get; set; }
        public double Rate { get; set; }
        public void getData()
        {
            Console.Write("Enter Id: ");
            OrderId = int.Parse(Console.ReadLine());
            Console.Write("Enter Date YYYY-MM-DD: ");
            OrderDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            Qty = int.Parse(Console.ReadLine());
            Console.Write("Enter Amount: ");
            TotalAmt = int.Parse(Console.ReadLine());
            Console.Write("Payment Mode (Credit/Debit): ");
            PaymentMode = (Console.ReadLine());
            
            Console.WriteLine("Enter Cot Type (Wood/Seel): ");
            CotType = Console.ReadLine();
            Console.Write("Enter Capacity (Single/Double): ");
            capacity = int.Parse(Console.ReadLine());
            Console.Write("Enter Rate: ");
            Rate = double.Parse(Console.ReadLine());
        }
        public void ShowData()
        {
            Console.Write($"Id: {OrderId}\nDate: {OrderDate}");
            if (FurnitureType == null)
            {
                Console.Write("\n");
            }
            else
            {
                Console.WriteLine($"Furniture Type: {FurnitureType}");
            }
            Console.WriteLine($"Quantity: {Qty}");
            Console.WriteLine($"Total Amount: {TotalAmt}");
            Console.WriteLine($"Payment Mode: {PaymentMode}");
            Console.WriteLine($"Cot Type: {CotType}\nCapacity: {capacity}\nRate: {Rate}");
        }
    }

    public class Program
    {
        static void Main()
        {
            string FurnitureType;
            Console.WriteLine("Enter Furniture Type(Chair/Cot): ");
            FurnitureType = Console.ReadLine();

            
            if (FurnitureType == "Chair")
            {
                Chair furniture = new Chair();
                furniture.getData();
                furniture.ShowData();
            }
            else if (FurnitureType == "Cot")
            {
                Cot furniture = new Cot();
                furniture.getData();
                furniture.ShowData();
            }
            else
            {
                Console.WriteLine("Invalid Furniture Type!");
                return;
            }
           

        }
    }
}
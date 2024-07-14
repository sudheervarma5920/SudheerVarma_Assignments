using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class BookStore
    {

        public string isbn { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

        public BookStore(string isbn,string name,string title,string author,int quantity,double price)
        {
            this.isbn = isbn;   
            this.name = name;
            this.title = title;
            this.author = author;
            this.quantity = quantity;
            this.price = price;
        }

        public double TotalAmount() { return quantity*price; }

        public void Displayinfo()
        {
            Console.WriteLine("Book details are");
            Console.WriteLine($"ISBN: {isbn}");
            Console.WriteLine($"Book Name: {name}");
            Console.WriteLine($"Book Title: {title}");
            Console.WriteLine($"Book Author: {author}");
            Console.WriteLine($"Quantity of Books: {quantity}");
            Console.WriteLine($"Book Price: {price}");
            Console.WriteLine($"Total Price: {TotalAmount()}");
        }

        public static void Main()
        {
            Console.WriteLine("Enter number of books");
            int num = int.Parse(Console.ReadLine());

            double totalBill = 0;

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine($"\nEnter details for book {i}:");

                Console.Write("Enter ISBN: ");
                string isbn = Console.ReadLine();

                Console.Write("Enter Book Name: ");
                string bookName = Console.ReadLine();

                Console.Write("Enter Book Title: ");
                string bookTitle = Console.ReadLine();

                Console.Write("Enter Book Author: ");
                string bookAuthor = Console.ReadLine();

                Console.Write("Enter Quantity of Books: ");
                int quantityOfBooks = int.Parse(Console.ReadLine());

                Console.Write("Enter Book Price: ");
                double bookPrice = double.Parse(Console.ReadLine());

                BookStore book = new BookStore(isbn, bookName, bookTitle, bookAuthor, quantityOfBooks, bookPrice);

                book.Displayinfo();

                
                totalBill += book.TotalAmount();
            }

            Console.WriteLine($"\nTotal Bill Amount:{totalBill}");
        }


    }
}

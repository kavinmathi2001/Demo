using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO Library Management Application");
            Console.ReadLine();
            Console.WriteLine("You can Add Book OR patrons" );
            Console.ReadLine();
            Console.WriteLine("For Adding Book,press 'B' ");
            Console.WriteLine("For Adding Patrons,please press 'p' ");
            string Option = (Console.ReadLine());
            if(Option.ToLower()== "b")
            {
                Console.WriteLine("Thanks For Choosing Add Book Option");
                Console.WriteLine("Please Enter Book Details");
                List<Book> booklist = new List<Book>();
                Book bookdetails = new Book();
                bookdetails.AddBook(booklist);
                bookdetails.viewbookdetails(booklist);

            }
            else if (Option.ToLower() == "p")
            {
                Console.WriteLine("Thanks For Choosing Patron Option");
                Console.WriteLine("Please Enter Patron Details");
                Console.WriteLine(" ");
            }

        }
    }
}

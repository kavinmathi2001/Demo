using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    class Book
    {
        List<Book> books = new List<Book>();
        public int BookId { get; set; }
        public int BookisbnNumber { get; set; }
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public int Year { get; set; }
        public DateTime AddedTime { get; set; }
        public string AddedBy { get; set; }


        public Book(int bookid,int bookisbnnumber,string booktitle,string authorname,int year,DateTime addedtime,string addedby)
        {
            BookId = bookid;
            BookisbnNumber = bookisbnnumber;
            BookTitle = booktitle;
            AuthorName = authorname;
            Year = year;
            AddedTime = addedtime;
            AddedBy = addedby;
        }
        public void Add_book(Book book)
        {
            books.Add(book);
        }

        public List<Book> AddBook(List<Book> booklist)
        {
            Console.WriteLine("Pls Enter The Book Id");
            int BookId = int.Parse(Console.ReadLine());

            Console.WriteLine("Pls Enter The BookisbnNumber");
            int BookisbnNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Pls Enter The BookTitle");
            string BookTitle = Console.ReadLine();

            Console.WriteLine("Pls Enter The AuthorName ");
            string AuthorName = Console.ReadLine();

            Console.WriteLine("Pls Enter The Year");
            int Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Pls Enter The AddedTime");
           // DateTime AddedTime = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Pls Enter The AddedBy");
            string Addedby = Console.ReadLine();


            Book bookobject = new Book();
            bookobject.BookId = BookId;
            bookobject.BookisbnNumber = BookisbnNumber;
            bookobject.BookTitle = BookTitle;
            bookobject.AuthorName = AuthorName;
            bookobject.Year = Year;
            bookobject.AddedTime = DateTime.Now;
            booklist.Add(bookobject);
            Console.WriteLine("The bookdetails added succesfully");
            return booklist;
        }
        public void viewbookdetails(List<Book>booklist)
        {
            Console.WriteLine("Total number of available books"+ booklist.Count() );
            Console.WriteLine("Are want To view the book details? press yes or no ");
            
            string Option = (Console.ReadLine());
            if (Option.ToLower() == "yes")
            {
                Console.WriteLine("Thanks For Choosing view Book Option");
                for (int i = 0; i < booklist.Count(); i++)
                {
                    Console.WriteLine("book id is"+ booklist[i].BookId);
                    Console.WriteLine("book isbn number is"+ booklist[i].BookisbnNumber);
                    Console.WriteLine("booktitle is"+ booklist[i].BookTitle);
                    Console.WriteLine("the author name is"+ booklist[i].AuthorName);
                    Console.WriteLine("the year is"+ booklist[i].Year);
                    
                }
            }
            else if (Option.ToLower() == "no")
            {
                
                Console.WriteLine("Are you want remove the book details? yes or no");
                string Option1 = (Console.ReadLine());
                if (Option1.ToLower() == "yes")
                {
                    Console.WriteLine("pls enter book id");
                    int bookid =int.Parse( Console.ReadLine());
                    for (int i = 0; i < booklist.Count(); i++)
                    {
                        if (booklist[i].BookId == bookid)
                        {
                            Book a = new Book();
                            a = booklist[i];
                            booklist.Remove(a);
                            Console.WriteLine("The book id" + bookid + "removed succesfully");
                            Console.WriteLine("Total number of available books" + booklist.Count());
       
                            
                        }
                    }
                }
                
            }
            

        }
    }
}
          

           
                
              
      
       

    

        

    


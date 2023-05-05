using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    public class Catalog
    {
        IList<Book> books;
        public Catalog()
        {
         books  = new List<Book>();
        }
       

        public void AddBook(Book book)
        {
         books.Add(book);
        }
        public  void RemoveBook()
        {
            Console.WriteLine("Enter book isbn to remove book: ");
            var remove = int.Parse(Console.ReadLine());
            foreach(var book in books.ToList())
            {
                if(book.ISBN == remove)
                {
                    books.Remove(book);
                    Console.WriteLine("Books removed successfully");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Book not found!");
                }
            }
           
        }
        public void GetAvailableBooks()
        {
            foreach(var book in books)
            {
                Console.WriteLine(book);
                Console.WriteLine();
            }
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Book> Checkedout { get; set; }
        public User(string name,string email)
        {
            Name = name;
            Email = email;
            Checkedout = new List<Book>();
        }
        public void CheckOutBook(Book book)
        {
            if (book.CheckedOut == false)
            {
                Checkedout.Add(book);
            }
            else
            {
                Console.WriteLine($"{book.Title} is not available!");
            }
        }
        public void GetCheckedOutBooks()
        {
            foreach (var checkout in Checkedout)
           {
               Console.WriteLine($"Title:{checkout.Title}\nAuthor:{checkout.Author}\nISBN:{checkout.ISBN}");
            }
        }
    }
}

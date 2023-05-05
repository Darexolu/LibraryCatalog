namespace LibraryCatalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Promise", "Gbenga Dare", 12678, true);
            Book book2 = new Book("Merlin", "Steflon Don", 18984, false);
            Book book3 = new Book("Heart break", "Chimamanda", 34667, true);
            Book book4 = new Book("Sugar girl", "Mlik jon", 20982, true);
            Book book5 = new Book("Danger", "Wole soyinka", 75431, false);
            Book book6 = new Book("Manager", "Oluwo daniel", 35267, true);
            Catalog catalog = new Catalog();
            catalog.AddBook(book1);
            catalog.AddBook(book2);
            catalog.AddBook(book3);
            catalog.AddBook(book4);
            catalog.AddBook(book5);
            catalog.AddBook(book6);

            Console.WriteLine("Available books: ");
            Console.WriteLine();
            catalog.GetAvailableBooks();
            catalog.RemoveBook();
            catalog.RemoveBook();

            Console.WriteLine("Current books available: ");
            catalog.GetAvailableBooks();
            

            User user = new User("Damilare","dareolu12@gmail.com");
            user.CheckOutBook(book2);
            user.CheckOutBook(book4);

            Console.WriteLine();
            Console.WriteLine("Checkedout book:");
            user.GetCheckedOutBooks();







        }
    }
}
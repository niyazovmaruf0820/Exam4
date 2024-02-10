
using task6;
try
{
    Library library = new Library();
    while (true)
    {
        System.Console.WriteLine("Create");
        System.Console.WriteLine("Read");
        System.Console.WriteLine("Update");
        System.Console.WriteLine("Delete");
        System.Console.WriteLine("exit");
        string a = Console.ReadLine().ToUpper();
        if (a == "CREATE")
        {
            Book book = new Book();
            System.Console.WriteLine("!type book's id=>");
            book.Id = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("!type book's title=>");
            book.Title = Console.ReadLine();
            System.Console.WriteLine("!type book's author=>");
            book.Author = Console.ReadLine();
            library.AddBook(book);
        }
        if (a == "READ")
        {
            foreach (var item in library.DisplayBook())
            {
                System.Console.WriteLine("Book's id: " + item.Id);
                System.Console.WriteLine("Book's id: " + item.Title);
                System.Console.WriteLine("Book's id: " + item.Author);
                System.Console.WriteLine("-------------------------");
            }
        }
        if (a == "DELETE")
        {
            System.Console.WriteLine("!type id for deleting=>");
            int id = Convert.ToInt32(Console.ReadLine());
            library.DeleteBook(id);
        }
        if (a == "UPDATE")
        {

            Book book1 = new Book();
            System.Console.WriteLine("!type book's id=>");
            book1.Id = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("!type book's title=>");
            book1.Title = Console.ReadLine();
            System.Console.WriteLine("!type book's author=>");
            book1.Author = Console.ReadLine();
            library.UpdateBook(book1);
        }
        if (a == "EXIT") break;
    }
}
catch
{
    System.Console.WriteLine("Error in inputing something");
}

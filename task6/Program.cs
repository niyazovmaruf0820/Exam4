
using task6;

try
{
    Library library = new Library();
while(true)
{
    System.Console.WriteLine("Read");
    System.Console.WriteLine("Update");
    System.Console.WriteLine("Delete");
    System.Console.WriteLine("Create");
    System.Console.WriteLine("Get out");
    string a = Console.ReadLine();
    if (a == "Create" || a == "create" || a == "CREATE")
    {
        Book book = new Book();
        book.Id = Convert.ToInt32(Console.ReadLine());
        book.Title = Console.ReadLine();
        book.Author = Console.ReadLine();
        library.AddBook(book);
    }
    if (a == "Read" || a == "read" || a == "READ")
    {
        foreach (var item in library.DisplayBook())
        {
            System.Console.WriteLine(item.Id);
            System.Console.WriteLine(item.Title);
            System.Console.WriteLine(item.Author);
            System.Console.WriteLine("-------------------------");
        }
    }
    if (a == "DELETE" || a == "Delete" || a == "delete")
    {
        int i = Convert.ToInt32(Console.ReadLine());
        library.DeleteBook(i);
    }
    if (a == "Update" || a == "UPDATE" || a == "update")
    {
        Book book1 = new Book();
        book1.Id = Convert.ToInt32(Console.ReadLine());
        book1.Title = Console.ReadLine();
        book1.Author = Console.ReadLine();
        library.UpdateBook(book1);
    }
    if (a == "get out" || a == "Get out") break;
}
}
catch
{
    System.Console.WriteLine("Error");
}
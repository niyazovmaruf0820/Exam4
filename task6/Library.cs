namespace task6;

public class Library : ILibrary
{
    List<Book> books = new List<Book>();
    public void AddBook(Book book)
    {
        books.Add(book);
        System.Console.WriteLine("Successfully added");
    }
    public void DeleteBook(int id)
    {
        try
        {
            var book = books.FirstOrDefault(e => e.Id == id);
            books.Remove(book);
            System.Console.WriteLine("Successfully deleted");
        }
        catch
        {
            System.Console.WriteLine("List of Books is empty");
        }
        
    }

    public List<Book> DisplayBook()
    {
        return books;
    }

    public Book SearchByAuthor(string author)
    {
        var book = books.FirstOrDefault(e => e.Author == author);
        return book;
    }

    public Book SearchByTitle(string title)
    {
        var book = books.FirstOrDefault(e => e.Title == title);
        return book;
    }

    public void UpdateBook(Book book)
    {
        try
        {
            var _book = books.FirstOrDefault(e => e.Id == book.Id);
            _book.Author = book.Author;
            _book.Title = book.Title;
            System.Console.WriteLine("Successfully updated");
        }
        catch
        {
            System.Console.WriteLine("this list of books is empty");
        }
    }

}

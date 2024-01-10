namespace task6;

public class Library : ILibrary
{
    List<Book> books = new List<Book>();
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public string DeleteBook(int id)
    {
       if (books.Count > 0)
       {
         foreach (var item in books)
        {
            if (item.Id == id)
            {
            books.Remove(item);
            }
            else return"Not found";
        }
        return "Deleted";
       }
       else return "Nothing";
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

    public string UpdateBook(Book newBook)
    {
        if (books.Count > 0)
        {
            foreach (var item in books)
        {
            if (item.Id == newBook.Id)
            {
                item.Title = newBook.Title;
                item.Author = newBook.Author;
                
            }
            return "Not found";
        }
        return "Updated";
        }
        return "Nothing";
    }

}

namespace task6;

public interface ILibrary
{
    public void AddBook(Book book);
    public List<Book> DisplayBook();
    public string UpdateBook(Book newBook);
    public string DeleteBook(int id);
    public Book SearchByTitle(string title);
    public Book SearchByAuthor(string author);
}

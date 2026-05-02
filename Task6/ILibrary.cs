public interface ILibrary
{
    void AddBook(Book book);
    void DisplayBooks();
    void UpdateBook(int id, string newTitle, string newAuthor);
    void DeleteBook(int id);
    Book? SearchByTitle(string title);
    List<Book> SearchByAuthor(string author);
}

public class Library : ILibrary
{
    private List<Book> books = new List<Book>();

    public static void AddBook(Library library)
    {
        Console.Write("Введите id книги: ");
        int id = int.Parse(Console.ReadLine()!);

        Console.Write("Введите название книги: ");
        string title = Console.ReadLine()!;

        Console.Write("Введите автора книги: ");
        string author = Console.ReadLine()!;

        Book book = new Book(id, title, author);
        library.AddBook(book);

        Console.WriteLine("Книга добавлена.");
    }

    public static void UpdateBook(Library library)
    {
        Console.Write("Введите id книги: ");
        int id = int.Parse(Console.ReadLine()!);

        Console.Write("Введите новое название: ");
        string title = Console.ReadLine()!;

        Console.Write("Введите нового автора: ");
        string author = Console.ReadLine()!;

        library.UpdateBook(id, title, author);
        Console.WriteLine("Книга обновлена.");
    }

    public static void DeleteBook(Library library)
    {
        Console.Write("Введите id книги: ");
        int id = int.Parse(Console.ReadLine()!);

        library.DeleteBook(id);
        Console.WriteLine("Книга удалена.");
    }

    public static void SearchByTitle(Library library)
    {
        Console.Write("Введите название книги: ");
        string title = Console.ReadLine()!;

        Book? book = library.SearchByTitle(title);

        if (book == null)
        {
            Console.WriteLine("Книга не найдена.");
        }
        else
        {
            Console.WriteLine("Id: " + book.Id);
            Console.WriteLine("Название: " + book.Title);
            Console.WriteLine("Автор: " + book.Author);
        }
    }

    public static void SearchByAuthor(Library library)
    {
        Console.Write("Введите автора: ");
        string author = Console.ReadLine()!;

        List<Book> result = library.SearchByAuthor(author);

        if (result.Count == 0)
        {
            Console.WriteLine("Книги не найдены.");
        }
        else
        {
            foreach (Book book in result)
            {
                Console.WriteLine("Id: " + book.Id);
                Console.WriteLine("Название: " + book.Title);
                Console.WriteLine("Автор: " + book.Author);
                Console.WriteLine();
            }
        }
    }

    public void AddBook(Book book)
    {
        foreach (Book item in books)
        {
            if (item.Id == book.Id)
            {
                throw new Exception("Книга с таким id уже существует.");
            }
        }

        books.Add(book);
    }

    public void DisplayBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("Библиотека пуста.");
            return;
        }

        foreach (Book book in books)
        {
            Console.WriteLine($"Id: {book.Id}, Название: {book.Title}, Автор: {book.Author}");
        }
    }

    public void UpdateBook(int id, string newTitle, string newAuthor)
    {
        foreach (Book book in books)
        {
            if (book.Id == id)
            {
                book.Title = newTitle;
                book.Author = newAuthor;
                return;
            }
        }

        throw new Exception("Книга не найдена.");
    }

    public void DeleteBook(int id)
    {
        for (int i = 0; i < books.Count; i++)
        {
            if (books[i].Id == id)
            {
                books.RemoveAt(i);
                return;
            }
        }

        throw new Exception("Книга не найдена.");
    }

    public Book? SearchByTitle(string title)
    {
        foreach (Book book in books)
        {
            if (book.Title == title)
            {
                return book;
            }
        }

        return null;
    }

    public List<Book> SearchByAuthor(string author)
    {
        List<Book> result = new List<Book>();

        foreach (Book book in books)
        {
            if (book.Author == author)
            {
                result.Add(book);
            }
        }

        return result;
    }
}

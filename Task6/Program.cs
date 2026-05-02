Library library = new Library();
var work = true;

while (work)
{
    Console.WriteLine();
    Console.WriteLine("1-Добавить книгу");
    Console.WriteLine("2-Показать все книги");
    Console.WriteLine("3-Обновить книгу");
    Console.WriteLine("4-Удалить книгу");
    Console.WriteLine("5-Поиск по названию");
    Console.WriteLine("6-Поиск по автору");
    Console.WriteLine("7-Выход");
    Console.Write("Выберите пункт: ");

    string number = Console.ReadLine()!;

    try
    {
        if (number == "1")
        {
            Library.AddBook(library);
        }
        else if (number == "2")
        {
            library.DisplayBooks();
        }
        else if (number == "3")
        {
            Library.UpdateBook(library);
        }
        else if (number == "4")
        {
            Library.DeleteBook(library);
        }
        else if (number == "5")
        {
            Library.SearchByTitle(library);
        }
        else if (number == "6")
        {
            Library.SearchByAuthor(library);
        }
        else if (number == "7")
        {
            work = false;
            Console.WriteLine("Программа завершена.");
        }
        else
        {
            Console.WriteLine("Неверный пункт меню.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ошибка: " + ex.Message);
    }
}

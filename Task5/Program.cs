Stack<int> intStack = new Stack<int>();
Stack<string> stringStack = new Stack<string>();
bool isRunning = true;

while (isRunning)
{
    Console.WriteLine();
    Console.WriteLine("1. Push в стек int");
    Console.WriteLine("2. Pop из стека int");
    Console.WriteLine("3. Peek стека int");
    Console.WriteLine("4. Push в стек string");
    Console.WriteLine("5. Pop из стека string");
    Console.WriteLine("6. Peek стека string");
    Console.WriteLine("7. Выход");
    Console.Write("Выберите пункт: ");

    string? num = Console.ReadLine();

    try
    {
        switch (num)
        {
            case "1":
                Console.Write("Введите целое число: ");
                int number = int.Parse(Console.ReadLine()!);
                intStack.Push(number);
                Console.WriteLine("Число добавлено в стек int.");
                break;

            case "2":
                if (intStack.Empty())
                {
                    Console.WriteLine("Стек int пуст.");
                    break;
                }

                int rNumber = intStack.Pop();
                Console.WriteLine("Удалено число: " + rNumber);
                break;

            case "3":
                if (intStack.Empty())
                {
                    Console.WriteLine("Стек int пуст.");
                    break;
                }

                int topNumber = intStack.Peek();
                Console.WriteLine("Верхнее число: " + topNumber);
                break;

            case "4":
                Console.Write("Введите строку: ");
                string text = Console.ReadLine()!;
                stringStack.Push(text);
                Console.WriteLine("Строка добавлена в стек string.");
                break;

            case "5":
                if (stringStack.Empty())
                {
                    Console.WriteLine("Стек string пуст.");
                    break;
                }

                string removedText = stringStack.Pop();
                Console.WriteLine("Удалена строка: " + removedText);
                break;

            case "6":
                if (stringStack.Empty())
                {
                    Console.WriteLine("Стек string пуст.");
                    break;
                }

                string topText = stringStack.Peek();
                Console.WriteLine("Верхняя строка: " + topText);
                break;

            case "7":
                isRunning = false;
                Console.WriteLine("Программа завершена.");
                break;

            default:
                Console.WriteLine("Неверный пункт меню.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ошибка: " + ex.Message);
    }
}

string[] InputArray()
{
    Console.Write("Введите длину массива строк: ");
    int length;
    try
    {
        length = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException)
    {
        length = 0;
    }
    
    string[] array = new string[length];

    string element = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");
        element = Console.ReadLine()!;
        array[i] = element;
    }

    return array;
}

string[] ShorterArray(string[] array)
{
    string[] newArray = new string[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[newArray.Length - 1] = array[i];
        }
    }

    return newArray;
}

string StringifyArray(string[] array)
{
    string arr = $"[";
    if (array.Length > 0)
    {
        arr += $"\"{array[0]}\"";
        for (int i = 1; i < array.Length; i++)
        {
            arr += $", \"{array[i]}\"";
        }
    }
    arr += "]";
    return arr;
}

void Main()
{
    Console.WriteLine($"Нажмите Enter, чтобы показать примеры.");
    if (Console.ReadKey().Key == ConsoleKey.Enter)
    {
        string[][] examples = new string[][] {
            new string[] {"hello", "2", "world", ":-)"},
            new string[] {"1234", "1567", "-2", "computer science"},
            new string[] {"Russia", "Denmark", "Kazan"}
        };

        for (int i = 0; i < examples.Length; i++)
        {
            Console.WriteLine($"{StringifyArray(examples[i])} -> {StringifyArray(ShorterArray(examples[i]))}");
        }
    }
    else
    {
        Console.Write(" -> ");
    }

    Console.WriteLine($"Нажмите Enter, чтобы ввести массив с клавиатуры.");
    if (Console.ReadKey().Key == ConsoleKey.Enter)
    {
        string[] array = InputArray();
        Console.WriteLine($"{StringifyArray(array)} -> {StringifyArray(ShorterArray(array))}");
    }
    else
    {
        Console.Write(" -> Конец.");
    }
}

Main();
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите день (число):");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите месяц (число):");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите год (число):");
        int year = Convert.ToInt32(Console.ReadLine());

        // Форматируем строку даты с добавлением нулей, если нужно
        string formattedDate = $"{day:D2}/{month:D2}/{year}";

        // Выводим результат
        Console.WriteLine(formattedDate);
    }
}

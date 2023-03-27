using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();
        // A
        if (Regex.IsMatch(input, @"abcd(2023)1{7}0\1"))
        {
            Console.WriteLine("Строка соответствует шаблону");
            input = Regex.Replace(input, "2023", "happynewyear");
        }
        else
        {
            Console.WriteLine("Строка не соответсвует шаблону");
        }
        Console.WriteLine($"Результат a): {input}");
        // B
        MatchCollection matches = Regex.Matches(input, @"\d+");
        List<int> numbers = new List<int>();
        foreach (Match match in matches)
        {
            int number;
            if (int.TryParse(match.Value, out number))
            {
                numbers.Add(number);
            }
        }
        Console.Write("Результат b): ");

        //  сумма
        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i]);

            sum += numbers[i];

            if (i < numbers.Count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine($"\nСумма чисел: {sum}");
        // макс число и его индекс
        int max = int.MinValue;
        int maxIndex = -1;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
                maxIndex = i;
            }
        }
        Console.WriteLine($"Максимальное число: {max}, порядковый номер: {maxIndex + 1}");
        // С
        matches = Regex.Matches(input, @"\d+");
        List<string> decimalNumbers = new List<string>();
        foreach (Match match in matches)
        {
            decimalNumbers.Add(match.Value);
        }
        input = Regex.Replace(input, @"\d+", "number");
        Console.WriteLine($"Результат c): {input}");
    }
}

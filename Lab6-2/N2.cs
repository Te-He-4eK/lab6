using System;

class Program
{
    static void Main(string[] args)
    {
        string[] strings = new string[5];

        // Ввод строк с клавиатуры
        for (int i = 0; i < strings.Length; i++)
        {
            Console.Write($"Введите строку {i + 1}: ");
            strings[i] = Console.ReadLine();
        }

        // Вывод строк, содержащих "cat" два раза
        Console.WriteLine("Строки, содержащие 'cat' два раза:");
        foreach (string str in strings)
        {
            if (str.Contains("catcat") || str.Contains("catandcat"))
            {
                Console.WriteLine(str);
            }
        }

        // Замена слов, состоящих из 10 и более символов
        Console.WriteLine("Новые наборы строк:");
        foreach (string str in strings)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 10)
                {
                    words[i] = "*";
                }
                else if (words[i].Length > 0)
                {
                    char firstChar = words[i][0];
                    words[i] = new string(firstChar, words[i].Length);
                }
            }
            Console.WriteLine(string.Join(" ", words));
        }

        // Удаление суффиксов "ик"
        Console.WriteLine("Строки после удаления суффиксов 'ик':");
        foreach (string str in strings)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].EndsWith("ик"))
                {
                    words[i] = words[i].Substring(0, words[i].Length - 2);
                }
            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
}

using System;

namespace lab24._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку S: ");
            string s = Console.ReadLine();
            s = System.Text.RegularExpressions.Regex.Replace(s, @"\s+", " "); // убираем лишние пробелы
            string[] words = s.Split(' ');
            int min = words[0].Length;

            for (int i = 0; i < words.Length; i++)
                if (words[i].Length < min)
                    min = words[i].Length;

            Console.WriteLine("Длина самого короткого слова равна " + min);

        }
    }
}

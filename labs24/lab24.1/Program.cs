using System;

namespace lab24._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку S: ");
            string s = Console.ReadLine();
            s = System.Text.RegularExpressions.Regex.Replace(s, @"\s+", " "); // убираем лишние пробелы
            string[] words = s.Split(' ');
            int n = words.Length;

            Console.WriteLine("Количество слов равно " + n);
        }
    }
}

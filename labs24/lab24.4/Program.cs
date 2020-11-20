using System;

namespace lab24._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            s = s.ToLower(); // сокращаем условие
            int count = 0;

            for (int i = 0; i < s.Length; i++)
                if (s[i] == 'а' || s[i] == 'о' || s[i] == 'у' || s[i] == 'ы' || s[i] == 'и'
                    || s[i] == 'е' || s[i] == 'ё' || s[i] == 'ю' || s[i] == 'я' || s[i] == 'э')
                    count++;

            Console.WriteLine("Количество гласных букв равно " + count);
        }
    }
}

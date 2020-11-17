using System;

namespace lab23._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < s.Length; i++)
                if ((Convert.ToInt32(s[i]) >= 65 && Convert.ToInt32(s[i]) <= 90))
                    count++;

            Console.WriteLine("Количество прописных латинских букв = " + count);
        }
    }
}

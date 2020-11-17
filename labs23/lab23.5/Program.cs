using System;

namespace lab23._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку S: ");
            string s = Console.ReadLine();
            Console.Write("Введите строку S0: ");
            string s0 = Console.ReadLine();
            int count = 0;
            int index;
            int len = s0.Length;

            while (s.Contains(s0))
            {
                count++;
                index = s.IndexOf(s0);
                s = s.Remove(index, len);
            }

            Console.WriteLine("Количество вхождений равно " + count);
        }
    }
}

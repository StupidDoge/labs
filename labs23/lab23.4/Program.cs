using System;
using System.Text;

namespace lab23._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            Console.Write("Введите символ: ");
            char c = Convert.ToChar(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            foreach (char ch in s)
            {
                sb.Append(ch);

                if (ch == c)
                    sb.Append(c);
            }

            sb.ToString();

            Console.WriteLine(sb);
        }
    }
}

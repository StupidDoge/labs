using System;
using System.Text;

namespace lab23._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            char c = Convert.ToChar(Console.ReadLine());
            int code = char.ConvertToUtf32(Convert.ToString(c), 0);
            Console.WriteLine("Код символа = " + code);

            int previousCode = code - 1;
            int nextCode = code + 1;

            Console.WriteLine("Предыдущий символ: " + Convert.ToChar(previousCode));
            Console.WriteLine("Следующий символ: " + Convert.ToChar(nextCode));
        }
    }
}

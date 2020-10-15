using System;

namespace lab13._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int ans = 0;

            for (int i = 1; i <= (2 * n - 1); i += 2)
                ans += i;

            Console.WriteLine("Квадрат числа: " + ans);
        }
    }
}

using System;

namespace lab21._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк матрицы: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер строки: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int product = 1;

            Random random = new Random();

            int[,] a = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = random.Next(-10, 10);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------");

            for (int i = 0; i < n; i++)
            {
                sum += a[k - 1, i];
                product *= a[k - 1, i];
            }

            Console.WriteLine("Произведение элементов равно " + product + ", сумма равна " + sum);
        }
    }
}

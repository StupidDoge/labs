using System;

namespace lab21._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк матрицы: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int product = 1;
            int minProduct = 1;
            int num = 1;

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

            for (int i = 0; i < m; i++)
                minProduct *= a[i, 0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    product *= a[j, i];

                if (product < minProduct)
                {
                    minProduct = product;
                    num = i + 1;
                }

                product = 1;
            }

            Console.WriteLine("Минимальное произведение равно " + minProduct + " в столбце " + num);
        }
    }
}

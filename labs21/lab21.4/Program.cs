using System;

namespace lab21._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк матрицы: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double average = 0;
            int count = 0;

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
                for (int j = 0; j < m; j++)
                    average += a[j, i];

                average = (double) average / m;

                for (int j = 0; j < m; j++)
                    if (a[j, i] > average)
                        count++;

                average = 0;
            }

            Console.WriteLine("Кол-во элементов, больших среднего арифметического, равно " + count);
        }
    }
}

using System;

namespace lab21._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк матрицы: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isOdd = true;
            int number = 0;

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
                    if (a[j, i] % 2 == 0)
                        isOdd = false;

                if (isOdd)
                {
                    number = i + 1;
                    break;
                }

                isOdd = true;
            }

            Console.WriteLine(number);
        }
    }
}

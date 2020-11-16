using System;

namespace lab22._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк матрицы: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int min, max, jMax, jMin, t;

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
            {
                min = a[i, 0];
                max = a[i, 0];
                jMax = 0;
                jMin = 0;

                for (int j = 0; j < n; j++)
                {

                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        jMax = j;
                    }

                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        jMin = j;
                    }
                }

                t = a[i, jMax];
                a[i, jMax] = a[i, jMin];
                a[i, jMin] = t;
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}

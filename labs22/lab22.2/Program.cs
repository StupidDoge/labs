using System;

namespace lab22._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк матрицы: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int min, max, cMax, cMin;

            Random random = new Random();

            int[,] a = new int[m, n];
            int[] columnMax = new int[m];
            int[] columnMin = new int[m];

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

            min = a[0, 0];
            max = a[0, 0];
            cMin = 0;
            cMax = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[j, i] < min)
                    {
                        min = a[j, i];
                        cMin = i;
                    }

                    if (a[j, i] > max)
                    {
                        max = a[j, i];
                        cMax = i;
                    }
                }
            }

            for (int i = 0; i < m; i++)
                columnMax[i] = a[i, cMax];

            for (int i = 0; i < m; i++)
                columnMin[i] = a[i, cMin];

            for (int i = 0; i < m; i++)
                a[i, cMax] = columnMin[i];

            for (int i = 0; i < m; i++)
                a[i, cMin] = columnMax[i];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}

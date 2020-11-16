using System;

namespace lab22._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк матрицы: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int dimM = m / 2 - 1;
            int dimN = n / 2 - 1;

            int[,] a = new int[m, n];
            int[,] topQuarter = new int[m / 2, n / 2];
            int[,] bottomQuarter = new int[m / 2, n / 2];
            
            if (dimM < 0 || dimN < 0)
            {
                dimM = 0;
                dimN = 0;
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Convert.ToString(i + 1) + Convert.ToString(j + 1));
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------");

            for (int i = 0; i < m / 2; i++)
                for (int j = 0; j < n / 2; j++)
                    topQuarter[i, j] = a[i, j];

            for (int i = m - 1; i >= m / 2; i--)
                for (int j = n - 1; j >= n / 2; j--)
                    bottomQuarter[m - i - 1, n - j - 1] = a[i, j];

            for (int i = 0; i < m / 2; i++)
                for (int j = 0; j < n / 2; j++)
                    a[i, j] = bottomQuarter[m / 2 - i - 1, n / 2 - j - 1];

            for (int i = m / 2; i < m; i++)
                for (int j = n / 2; j < n; j++)
                     a[m - i + dimM, n - j + dimN] = topQuarter[m - i - 1, n - j - 1];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}

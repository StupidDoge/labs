using System;
using System.Collections.Generic;

namespace lab22._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность матрицы: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int sum;

            Random random = new Random();

            int[,] a = new int[m, m];
            List<int> sums = new List<int>();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = random.Next(-10, 10);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------- ");

            for (int i = 0; i < m; i++) // идём сверху вниз, так удобнее решать
            {
                sum = 0;
                for (int j = 0; j < i; j++)
                    sum += a[j, m - i + j];
                if (i != 0) // чтобы не добавлялся лишний 0 в список сумм
                    sums.Add(sum);
            }

            for (int i = m; i >= 0; i--)
            {
                sum = 0;
                for (int j = 0; j < i; j++)
                    sum += a[m - i + j, j];
                if (i != 0)
                    sums.Add(sum);
            }

            sums.Reverse(); // переворачиваем список и в выводе идём снизу вверх, так вывод становится интуитивно понятнее

            for (int i = 0; i < sums.Count; i++)
                Console.WriteLine("Сумма элементов " + (i + 1) + " диагонали равна " + sums[i]);
        }
    }
}

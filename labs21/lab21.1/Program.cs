using System;

namespace lab21._1
{
    class Program
    {
        /* алгоритм, кстати, работает на матрицах любых размерностей, в том числе и чётных */

        static void Main(string[] args)
        {
            Console.Write("Введите M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int down = 0; // начальное направление движения по матрице - вниз
            int right = 1; // потом вправо, идём так сразу после движения вниз
            int up = m - 1; // доходим до конца, идём наверх
            int left = m - 1; // возвращаемся к началу, то есть двигаемся влево (но не доходим до уже выведенного элемента)
            int[,] a = new int[m, m];
            int n = m / 2 + 1; // количество проходов спиралью по матрице

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // подобный вывод чисел (число = своим индексам [i, j]) задан с целью облегчения тестирования 
                    a[i, j] = Convert.ToInt32(Convert.ToString(i + 1) + Convert.ToString(j + 1));
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------");

            for (int k = 0; k < n; k++)
            {

                for (int i = down; i < m - k; i++)
                    Console.Write(a[i, k] + " ");

                for (int j = right; j < m - (k + 1); j++)
                    Console.Write(a[m - (k + 1), j] + " ");

                for (int i = up; i > k; i--)
                    Console.Write(a[i, m - (k + 1)] + " ");

                for (int j = left; j > k; j--)
                    Console.Write(a[k, j] + " ");

                // увеличиваем и уменьшаем счётчики движения по направлениям, чтобы "углубляться" в матрицу и идти по спирали
                down++;
                right++;
                up--;
                left--;
            } 
        }
    }
}
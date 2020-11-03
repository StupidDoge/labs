using System;
using System.Collections.Generic;

namespace lab19._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N be like: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x;

            List<int> a = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                x = Convert.ToInt32(Console.ReadLine());
                a.Add(x);
            }

            for (int i = 0; i < a.Count - 1; i++)
            {
                int j = i;
                try
                {
                    while (a[j] == a[j + 1])
                        a.RemoveAt(j + 1);
                } catch (System.ArgumentOutOfRangeException ex)
                {
                    // Лечит ошибку, когда цепочка одинаковых элементов идёт в конце массива.
                    // На последнем элементе инструкция a[j + 1] выкидывает исключение и крашит прогу.
                    // Мы просто оборачиваем опасный блок кода в try-catch и избегаем ошибки. 
                }
            }

            Console.WriteLine("-------");

            for (int i = 0; i < a.Count; i++)
                Console.WriteLine("a[" + i + "] = " + a[i]);
        }
    }
}

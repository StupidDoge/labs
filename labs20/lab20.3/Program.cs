using System;
using System.Collections.Generic;

namespace lab20._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N enters the chat: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("K enters the chat: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int x;
            int count = 0;
            int amount = 0; // серии, ищет нужную и в конце принимает значения номера последней серии
            int position = -1; // сюда запишем позицию, куда надо вставить последнюю серию

            List<int> a = new List<int>();
            List<int> t1 = new List<int>(); // вспомогательный массив для серии с номером K
            List<int> t2 = new List<int>(); // вспомогательный массив для последней серии

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                x = Convert.ToInt32(Console.ReadLine());
                a.Add(x);
            }

            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < a.Count; j++) // считаем длину текущей серии
                    if (a[i] == a[j])
                        count++;

                amount++; // считаем количество серий
                if (amount == k) // находим серию с номером k
                {
                    position = i; 
                    for (int j = 0; j < count; j++)
                        t1.Add(a[i]);
                }

                i += count - 1; // перескакиваем с серии на серию

                if (i == a.Count - 1) // выделяем последнюю серию
                    for (int j = 0; j < count; j++)
                        t2.Add(a[i]);

                count = 0; // обнуляем количество элементов текущей серии в конце цикла
            }

            /* удаляем серию k, вставляем последнюю на её место, удаляем последнюю, вставляем серию k в конец */
            a.RemoveRange(position, t1.Count);
            a.InsertRange(position, t2);
            a.RemoveRange(a.Count - t2.Count, t2.Count);
            a.AddRange(t1);

            Console.WriteLine("-------");

            for (int i = 0; i < a.Count; i++)
                Console.WriteLine("a[" + i + "] = " + a[i]);
        }
    }
}

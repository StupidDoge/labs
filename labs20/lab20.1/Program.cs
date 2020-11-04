using System;
using System.Collections.Generic;

namespace lab20._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N enters the chat: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x;
            int count = 0;

            List<int> a = new List<int>();
            List<int> b = new List<int>();
            List<int> c = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                x = Convert.ToInt32(Console.ReadLine());
                a.Add(x);
            }

            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < a.Count; j++)
                    if (a[i] == a[j])
                        count++;

                b.Add(count);
                c.Add(a[i]);
                i += count - 1; // необходимо для корректного заполнения массивов b и c
                count = 0;
            }


            Console.WriteLine("-------");

            Console.WriteLine("Длины серий: ");
            for (int i = 0; i < b.Count; i++)
                Console.WriteLine("b[" + i + "] = " + b[i]);

            Console.WriteLine("Значения элементов в сериях: ");
            for (int i = 0; i < c.Count; i++)
                Console.WriteLine("c[" + i + "] = " + c[i]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading;

namespace lab19._2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("N be like: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x;
            int count = 0;

            List<int> a = new List<int>();
            List<int> t = new List<int>();

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

                if (count == 2)
                    t.Add(a[i]);

                count = 0;
            }

            for (int i = 0; i < t.Count; i++)
                a.RemoveAll(item => item == t[i]);

            Console.WriteLine("-------");
            Console.WriteLine("Размер нового массива равен " + a.Count);

            for (int i = 0; i < a.Count; i++)
                Console.WriteLine("a[" + i + "] = " + a[i]);
        }
    }
}

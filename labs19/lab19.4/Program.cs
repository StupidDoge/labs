using System;
using System.Collections.Generic;

namespace lab19._4
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

            for (int i = 0; i < a.Count; i++)
                if (a[i] < 0)
                    a.Insert(i + 1, 0);

            if ((a[n - 1] < 0) && (n % 2 == 0))
                a.Add(0);

            Console.WriteLine("-------");

            for (int i = 0; i < a.Count; i++)
                Console.WriteLine("a[" + i + "] = " + a[i]);
        }
    }
}

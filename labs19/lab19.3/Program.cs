using System;
using System.Collections.Generic;

namespace lab19._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N be like: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x;
            int min, max;
            int iMin = 0;
            int iMax = 0;

            List<int> a = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                x = Convert.ToInt32(Console.ReadLine());
                a.Add(x);
            }

            min = a[0];
            max = a[0];

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    iMax = i;
                }

                if (a[i] < min)
                {
                    min = a[i];
                    iMin = i;
                }
            }

            a.Insert(iMin, 0);
            if (iMax == n - 1)
                a.Add(0);
            else
                a.Insert(iMax + 1, 0);

            Console.WriteLine("-------");

            for (int i = 0; i < a.Count; i++)
                Console.WriteLine("a[" + i + "] = " + a[i]);
        }
    }
}

using System;
using System.Collections.Generic;

namespace lab20._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N enters the chat: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("L enters the chat: ");
            int l = Convert.ToInt32(Console.ReadLine());
            int x;
            int count = 0;

            List<int> a = new List<int>();

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
                if (count > l)
                {
                    a.RemoveRange(i, count);
                    a.Insert(i, 0);
                }

                count = 0;
            }

            Console.WriteLine("-------");

            for (int i = 0; i < a.Count; i++)
                Console.WriteLine("a[" + i + "] = " + a[i]);
        }
    }
}

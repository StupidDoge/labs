using System;
using System.Collections.Generic;
using System.Linq;

namespace lab24._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            List<char> result = new List<char>();
            string resultString;

            for (int i = 1; i < s.Length; i += 2)
                result.Add(s[i]);

            if (s.Length % 2 == 0)
                for (int i = s.Length - 2; i >= 0; i -= 2)
                    result.Add(s[i]);
            else
                for (int i = s.Length - 1; i >= 0; i -= 2)
                    result.Add(s[i]);

            resultString = new string(result.ToArray());
            Console.WriteLine(resultString);
        }
    }
}

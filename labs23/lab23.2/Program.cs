using System;

namespace lab23._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            string ans = "";

            for (int i = 1; i < s.Length - 1; i++)
            {
                if (Convert.ToInt32(s[i]) == 32 && Convert.ToInt32(s[i - 1]) != 32
                    && Convert.ToInt32(s[i + 1]) != 32)
                    ans = ans + Convert.ToString(s[i - 1]) + Convert.ToString(s[i + 1]); 
            }

            Console.WriteLine(ans);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace lab24._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            char[] s0 = s.ToCharArray();
            int lastSlash = s.LastIndexOf('\\');
            int penultimateSlash = 0;
            int slashCount = 0;
            int fileName;
            string directory;
            List<char> charString = s0.OfType<char>().ToList();

            for (int i = 0; i < charString.Count; i++)
                if (s[i] == '\\')
                    slashCount++;

            for (int i = 0; i < lastSlash; i++)
                if (s[i] == '\\')
                    penultimateSlash = i;

            if (slashCount != 1) // если слэш один, то файл в корневом каталоге => выводим "\"
            {
                charString.RemoveRange(0, penultimateSlash + 1);
                lastSlash = charString.LastIndexOf('\\');
                fileName = charString.Count - lastSlash;
                charString.RemoveRange(lastSlash, fileName);

                directory = new string(charString.ToArray());
            }
            else
                directory = @"\";

            Console.WriteLine("Имя каталога: " + directory);
        }
    }
}

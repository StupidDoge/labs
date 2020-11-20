using System;
using System.Collections.Generic;
using System.Linq;

namespace lab24._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            char[] s0 = s.ToCharArray();
            int lastSlash = s.LastIndexOf('\\');
            int pointIndex = 0;
            int extension;
            string fileName;
            List<char> charString = s0.OfType<char>().ToList();

            charString.RemoveRange(0, lastSlash + 1);

            for (int i = 0; i < charString.Count; i++)
                if (charString[i] == '.')
                    pointIndex = i;

            extension = charString.Count - pointIndex;
            charString.RemoveRange(pointIndex, extension);

            fileName = new string(charString.ToArray());

            Console.WriteLine("Имя файла: " + fileName);
        }
    }
}

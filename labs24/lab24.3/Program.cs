using System;
using System.Text;

namespace lab24._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            char[] charString = s.ToCharArray();
            char fisrtLetter = s[0];

            for (int i = 1; i < charString.Length; i++)
                if ((charString[i - 1] == ' ') && (charString[i] != ' '))
                    fisrtLetter = charString[i];
                else if (charString[i] == fisrtLetter)
                    charString[i] = '.';

            s = new string(charString);

            Console.WriteLine("Новая строка:   " + s);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lab25._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя файла: ");
            string fileName = Console.ReadLine();
            string textFromFile;
            char[] letters;
            List<char> textList = new List<char>();
            int paragraphCount = 0;

            string path = $@"C:\Users\Денис Литвинец\Documents\учеба\Mospolytech\ВВП\labs25\{fileName}.txt";

            using (StreamReader sr = new StreamReader(path))
                textFromFile = sr.ReadToEnd();

            letters = textFromFile.ToCharArray();
            textList = letters.OfType<char>().ToList();

            for (int i = 0; i < textList.Count; i++)
                if (textList[i] == Convert.ToChar("\n"))
                    textList.RemoveAt(i);

            for (int i = 0; i < textList.Count - 5; i++)
            {
                if (textList[i] == ' ' && textList[i + 1] == ' ' && textList[i + 2] == ' '
                    && textList[i + 3] == ' ' && textList[i + 4] == ' ')
                    paragraphCount++;
            }

            Console.WriteLine("Количество абзацев равно " + paragraphCount);

        }
    }
}

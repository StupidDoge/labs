using System;
using System.Collections.Generic;
using System.IO;

namespace lab25._4
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Введите имя файла: ");
            string fileName = Console.ReadLine();
            string textFromFile;
            char[] letters;
            List<char> clearCharList = new List<char>();
            string clearText;

            string path = $@"C:\Users\Денис Литвинец\Documents\учеба\Mospolytech\ВВП\labs25\{fileName}.txt";

            using (StreamReader sr = new StreamReader(path))
                textFromFile = sr.ReadToEnd();

            Console.WriteLine($"Из {fileName}.txt извлечён следующий текст: {textFromFile}");

            letters = textFromFile.ToCharArray();
            clearCharList.Add(letters[0]);

            for (int i = 1; i < letters.Length; i++)
                if ((letters[i] != ' ') || ((letters[i] == ' ') && (letters[i - 1] != ' ')))
                    clearCharList.Add(letters[i]);

            clearText = new string(clearCharList.ToArray());
            File.WriteAllText(path, string.Empty);

            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                sw.Write(clearText);

            Console.Write($"В {fileName}.txt записан следующий текст: {clearText}");
        }
    }
}

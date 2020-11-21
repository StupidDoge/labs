using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lab25._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Денис Литвинец\Documents\учеба\Mospolytech\ВВП\labs25\file for lab 25-1.txt";
            string newFileText;
            
            Console.Write("Введите строку для записи в файл: ");
            string text = Console.ReadLine();

            using (FileStream fstream = new FileStream($"{path}", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);
            }

            using (FileStream fstream = File.OpenRead($"{path}"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                char[] helperArray = textFromFile.ToCharArray();
                List<char> textArray = helperArray.OfType<char>().ToList();

                int index = textArray.IndexOf(' ') + 1;
                textArray.RemoveRange(0, index);
                newFileText = new string(textArray.ToArray());

                Console.WriteLine("Новый текст для файла: " + newFileText);
            }

            using (FileStream fstream = new FileStream($"{path}", FileMode.Truncate))
            {
                byte[] emptyArray = { };
                fstream.Write(emptyArray, 0, 0);
                byte[] arrayToWrite = System.Text.Encoding.Default.GetBytes(newFileText);
                fstream.Write(arrayToWrite, 0, arrayToWrite.Length);
            }
        }
    }
}

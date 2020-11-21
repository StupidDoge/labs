using System;
using System.IO;

namespace lab25._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя первого файла: ");
            string fileName1 = Console.ReadLine();
            Console.Write("Введите имя второго файла: ");
            string fileName2 = Console.ReadLine();
            Console.Write("Текст для первого файла: ");
            string textForFile1 = Console.ReadLine();
            Console.Write("Текст для второго файла: ");
            string textForFile2 = Console.ReadLine();

            string path1 = $@"C:\Users\Денис Литвинец\Documents\учеба\Mospolytech\ВВП\labs25\{fileName1}.txt";
            string path2 = $@"C:\Users\Денис Литвинец\Documents\учеба\Mospolytech\ВВП\labs25\{fileName2}.txt";
            string textFromFile1 = "";
            string textFromFile2 = "";

            using (StreamWriter sw = new StreamWriter(path1, false, System.Text.Encoding.Default))
                sw.WriteLine(textForFile1);

            using (StreamWriter sw = new StreamWriter(path2, false, System.Text.Encoding.Default))
                sw.WriteLine(textForFile2);

            using (StreamReader sr = new StreamReader(path1))
                textFromFile1 = sr.ReadToEnd();

            using (StreamReader sr = new StreamReader(path2))
                textFromFile2 = sr.ReadToEnd();


            File.WriteAllText(path1, string.Empty);

            using (StreamWriter sw = new StreamWriter(path1, false, System.Text.Encoding.Default))
            {
                sw.Write(textFromFile2);
                sw.Write(textFromFile1);
            }

            Console.WriteLine($"В начало файла {fileName1} добавлен текст из {fileName2}");
        }
    }
}

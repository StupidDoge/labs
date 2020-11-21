using System;
using System.IO;

namespace lab25._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя файла: ");
            string fileName = Console.ReadLine();
            Console.Write("Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите K: ");
            int k = Convert.ToInt32(Console.ReadLine());

            string path = $@"C:\Users\Денис Литвинец\Documents\учеба\Mospolytech\ВВП\labs25\{fileName}.txt";
            
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < k; j++)
                        sw.Write('*');

                    sw.Write("\n");
                }
            }

            Console.WriteLine($"В файл с именем {fileName} записаны {n} строк(-и) по {k} символов(-а) \"*\"");
        }
    }
}

using System;

namespace lab7._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j; // счётчики
            double x, y; // неизвестные и коэффициенты
            double[,] a = new double[2, 3]; // матрица коэффициентов 
            Console.WriteLine("Система линейных уравнений вида");
            Console.WriteLine("A1*x + B1*y = C1");
            Console.WriteLine("A2*x + B2*y = C2");

            for (i = 0; i < a.GetLength(0); i++)
                for (j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("a[" + i + "][" + j + "] = ");
                    a[i, j] = Convert.ToDouble(Console.ReadLine());
                }

            Console.WriteLine(a[0, 0] + "x + " + a[0, 1] + "y = " + a[0, 2]);
            Console.WriteLine(a[1, 0] + "x + " + a[1, 1] + "y = " + a[1, 2]);
            Console.WriteLine("-----");
        }
    }
}

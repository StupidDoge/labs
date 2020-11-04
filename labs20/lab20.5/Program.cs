using System;
using static System.Math;

namespace lab20._5
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("N enters the chat: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double maxPerimeter = 0;
            double perimeter;

            double[,] coord = new double[2, 10000]; // К О С Т Ы Л Ь
            double[] ansCoord = { 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < n; i++)
            {
                Console.Write("x" + (i + 1) + " = ");
                coord[0, i] = Convert.ToDouble(Console.ReadLine());

                Console.Write("y" + (i + 1) + " = ");
                coord[1, i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < n - 2; i++)
                for (int j = i + 1; j < n - 1; j++)
                    for (int k = j + 1; k < n; k++)
                    {
                        perimeter = CountPerimeter(coord[0, i], coord[1, i], coord[0, j], coord[1, j], coord[0, k], coord[1, k]);
                        if (perimeter > maxPerimeter)
                        {
                            maxPerimeter = perimeter;
                            ansCoord[0] = coord[0, i];
                            ansCoord[1] = coord[1, i];
                            ansCoord[2] = coord[0, j];
                            ansCoord[3] = coord[1, j];
                            ansCoord[4] = coord[0, k];
                            ansCoord[5] = coord[1, k];
                        }
                    }

            Console.WriteLine("Наибольший периметр = " + maxPerimeter);
            Console.WriteLine("Координаты точек: (" + ansCoord[0] + "; " + ansCoord[1] + "), (" 
                + ansCoord[2] + "; " + ansCoord[3] + "), (" + ansCoord[4] + "; " + ansCoord[5] + ").");
        }

        static double CountPerimeter(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return Sqrt(Pow(x2 - x1, 2) + Pow(y2 - y1, 2)) + Sqrt(Pow(x3 - x1, 2) + Pow(y3 - y1, 2)) + Sqrt(Pow(x3 - x2, 2) + Pow(y3 - y2, 2));
        }
    }
}

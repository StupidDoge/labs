using System;
using System.Collections.Generic;
using static System.Math;

namespace lab20._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N enters the chat: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double x, y;
            double pointX = 0;
            double pointY = 0;
            double length;
            double maxLength = 0;

            List<double> coordX = new List<double>();
            List<double> coordY = new List<double>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("x" + (i + 1) + " = ");
                x = Convert.ToDouble(Console.ReadLine());
                coordX.Add(x);

                Console.Write("y" + (i + 1) + " = ");
                y = Convert.ToDouble(Console.ReadLine());
                coordY.Add(y);
            }

            for (int i = 0; i < n; i++)
            {
                if (coordX[i] < 0 && coordY[i] > 0)
                {
                    length = Sqrt(Pow(coordX[i], 2) + Pow(coordY[i], 2));
                    if (length > maxLength)
                    {
                        maxLength = length;
                        pointX = coordX[i];
                        pointY = coordY[i];
                    }
                }
            }

            Console.WriteLine("(" + pointX + "; " + pointY + ")");
        }
    }
}

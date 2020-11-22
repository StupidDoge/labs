using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_alculator__Sharp
{
    class Calculator: InterfaceCalculator
    {
        private double a = 0;

        public void PutNumber(double a)
        {
            this.a = a;
        }

        public void DeleteNumber()
        {
            a = 0;
        }

        public double Multiplication(double b)
        {
            return a * b;
        }

        public double Division(double b)
        {
            return a / b;
        }

        public double Addition(double b)
        {
            return a + b;
        }

        public double Subtraction(double b)
        {
            return a - b;
        }

        public double ArbitraryRoot(double b)
        {
            return Math.Pow(a, 1 / b);
        }

        public double Division1X(double b)
        {
            return 1 / b;
        }

        public double XDegreeY(double b)
        {
            return Math.Pow(a, b);
        }

        public double Sqrt(double b)
        {
            return Math.Sqrt(b);
        }

        public double Square(double b)
        {
            return Math.Pow(b, 2.0);
        }

        public double Factorial(double b)
        {
            double f = 1;

            for (int i = 1; i <= b; i++)
                f *= i;

            return f;
        }

        public double Absolute(double b)
        {
            return Math.Abs(b);
        }

        public double Modulo(double b)
        {
            return a % b;
        }

        public double Pi()
        {
            return Math.PI;
        }

        public double E()
        {
            return Math.E;
        }

        public double NaturalLog(double b)
        {
            return Math.Log(b);
        }

        public double LogXY(double b)
        {
            return Math.Log(a, b);
        }
    }
}

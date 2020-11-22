using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_alculator__Sharp
{
    public interface InterfaceCalculator
    {
        void PutNumber(double a);

        void DeleteNumber();

        double Multiplication(double b);

        double Division(double b);

        double Addition(double b);

        double Subtraction(double b);

        double ArbitraryRoot(double b);

        double Division1X(double b);

        double XDegreeY(double b);

        double Sqrt(double b);

        double Square(double b);

        double Factorial(double b);

        double Absolute(double b);

        double Modulo(double b);

        double Pi();

        double E();

        double NaturalLog(double b);

        double LogXY(double b);
    }
}

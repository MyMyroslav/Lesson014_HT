using System;
namespace Lesson014_HT
{
    static class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        static public double Sub(double x, double y)
        {
            return x - y;
        }

        static public double Mul(double x, double y)
        {
            return x * y;
        }

        static public double Div(double x, double y)
        {
            if (x == 0)
            {
                return 0;
            }
            return x / y;
        }
    }
}
  
using System;

namespace Maturita
{
    class Program
    {
        public static double fce(double x)
        {
            return Math.Pow(x, 2) -5 * x + 13;
        }
        static void Main(string[] args)
        {
            double a = 1, b = 3, n = 10,x;
            
            double krok = (b - a) / n;
            double součet= 0;
            do
            {
                x = a;
                a += krok;
                součet += ((a-x) / 6) * (fce(a) + 4 * fce((a + x) / 2) + fce(x));
            }
            while (a < b);
            Console.WriteLine(součet);
            
        }
    }
}

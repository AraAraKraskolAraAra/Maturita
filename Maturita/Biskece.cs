using System;

namespace Maturita
{
    class Program
    {
       public static double fce(double x)
        {
            return Math.Cos(x) - x;
        }
        static void Main(string[] args)
        {
            double a = 0;
            double b = 1;

            double přesnost = 0.03;
            double c;
            double p;

            Console.WriteLine("a: f(a)\t\t\tb: f(b)\t\t\tc: f(c)");

            do
            {
                c = (a + b) / 2;
                p = (b - a) / 2;

                Console.WriteLine("{0}: {1:F4}\t\t{2}: {3:F4}\t\t{4}: {5:F4}", a, fce(a), b, fce(b), c, fce(c));

                if (fce(b) * fce(c) < 0)
                {
                    a = c;
                }
                if (fce(a) * fce(c) < 0)
                {
                    b = c;
                }
            }
            while (p > přesnost);
        }
    }
}

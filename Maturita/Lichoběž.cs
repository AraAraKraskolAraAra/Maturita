using System;

namespace Maturita
{

    class Program
    {
        static double f(double a)
        {
            return Math.Sin(a);
        }
       
        static void Main(string[] args)
        {
            double a = 0;
            double b = Math.PI;
            double n = 10,x;

            double interval = (b - a) / n;
            double součet=0;

            do
            {
                x = a;  


                a += interval;
                součet += (f(a) + f(x)) * (a - x) / 2;
            }
            while (a<b);

            Console.WriteLine(součet);
            Console.WriteLine();
        }
    }
}

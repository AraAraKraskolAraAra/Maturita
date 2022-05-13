using System;

namespace Maturita
{
    class Program
    {
    public static double fce(double x)
        {
            return Math.Cos(x) - x;
        }
        public static double Dfce(double x)
        {
            return -Math.Sin(x) - 1;
        }
        public static double DDfce(double x)
        {
            return Math.Cos(x);
        }

        static void Main(string[] args)
        {
          double dol =0, hor = 1, přes = 0.03, x, xs;
            if (fce(dol) * DDfce(dol) > 0)
            {
                x = dol;
            }
            else x = hor;

            do
            {
                xs = x;
                x = x - fce(x) / Dfce(x);
            }
            while (Math.Abs(x-xs) > přes);
            Console.WriteLine(x);
            
        }
    }
}

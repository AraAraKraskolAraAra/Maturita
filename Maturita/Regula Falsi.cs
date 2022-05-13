using System;

namespace Maturita
{
    class Program
    {
        public static double RegulaFalsi(double x)
        {
            return Math.Pow((x / 2), 2) - Math.Sin(x);
        }


        static void Main(string[] args)
        {
            double dol = 1.5, hor = 2, přes = 0.3, x = 0, xs;

            do
            {
                xs = x;
                x = dol - (((hor - dol)) / ((RegulaFalsi(hor) - RegulaFalsi(dol))) * RegulaFalsi(dol));
                if (RegulaFalsi(dol) * RegulaFalsi(x) <= 0)
                {
                    hor = x;
                }
                else
                {
                    dol = x;
                }
            }
            while (Math.Abs(xs - x) > přes);
            Console.WriteLine(x);

        }
    }
}

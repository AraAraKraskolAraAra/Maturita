using System;

namespace Maturita
{
    class Program
    {
        public static double fakro(double x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * fakro(x - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo pro faktorial: ");
            double a = double.Parse(Console.ReadLine());
            double x = fakro(a);
            Console.WriteLine(x);


        }
    }
}

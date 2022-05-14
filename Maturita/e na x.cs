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
            Console.Write("Zadej hodnotu x pro výraz e^x: ");
            double k = double.Parse(Console.ReadLine());
            
            double y=1;
            for(double q =1; q<=Math.Pow(Math.E,k); q++)
            {
                 y +=Math.Pow(k, q) / fakro(q);
                
            }
           Console.WriteLine(y);

            

        }
    }
}

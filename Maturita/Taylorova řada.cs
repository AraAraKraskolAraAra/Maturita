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

            double y = 1;
            for (double q = 1; q <= Math.Cos(k); q++)
            {
                
                    y += -Math.Pow(k, q*2) / fakro(q);
                    if(y>0)
                    {
                        y *= -1;
                    }
                
                    
                
               
            }
            Console.WriteLine(y);




        }
    }
}

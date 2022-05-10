using System;

namespace Maturita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Není prvočíslo");
            }
            else
            {
                int i;
                int q;
                double k;
                k = Math.Sqrt(x);

                for (i = 2; i < k; i++)
                {
                    q = x % i;
                    if (q == 0)
                    {

                        Console.WriteLine("{1}   Není prvočíslo   {0}", q, i);
                        Console.ReadKey();

                    }
                }
                q = x % i;

                if (q != 0)
                {
                    Console.WriteLine("{1}   Je prvočíslo   {0}", q, i);
                    Console.ReadKey();

                }
            }
        }
    }
}

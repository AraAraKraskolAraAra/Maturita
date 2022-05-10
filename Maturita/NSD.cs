using System;

namespace Maturita
{
    class Program
    {
        public static int NSD (int x, int y)
        {
            if(x == y)
            {
                return x;
            }
            if (x >y)
            {
                return NSD(x - y, y);
            }
            else
            {
                return NSD(x, y - x);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Zadej první číslo: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Zadej druhé číslo: ");
            int y = int.Parse(Console.ReadLine());
            int a = NSD(x, y);
            Console.WriteLine(a);
        }
    }
}

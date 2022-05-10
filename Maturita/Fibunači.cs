using System;

namespace Maturita
{
    class Program
    {
        public static int Fibunaci(int x)
        {
            if(x == 0)
            { return 0; }
            if (x ==1)
            { return 1; }
            else { return (Fibunaci(x - 1) + Fibunaci(x - 2)); }
        }
        static void Main(string[] args)
        {
            Console.Write("Zadejte hledaný člen Fibunacciho posloupnosti: ");
            int x = int.Parse(Console.ReadLine());
            int y = Fibunaci(x);
            Console.WriteLine(y);

            int a = 1, b= 1,c;
            Console.Write("1\t");
            for(int i = 1; i <x; i++)
            {
                Console.Write("{0}\t", a);
                c = a;
                a += b;
                b = c;
            }
           
        }
    }
}

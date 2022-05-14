using System;

namespace Maturita
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            Console.Write("Jaké číslo je hledané (1-30): ");
            int x = int.Parse(Console.ReadLine());
            int q = 0;
            int[] A = new int[30];

            for (int i = 0; i < A.Length; i++)
            {
                if (i % 5 == 0) { Console.WriteLine(); }
                A[i] = rng.Next(1, 21);
                Console.Write($"{A[i],5}");

                if (A[i] == x)
                {
                   q++;
                }
               
            }
            Console.WriteLine();
            if (q == 0) Console.WriteLine($"Číslo {x} se nevyskytuje.");
            else Console.WriteLine($"Číslo {x} se vyskytuje {q}-krát.");
        }
    }
}

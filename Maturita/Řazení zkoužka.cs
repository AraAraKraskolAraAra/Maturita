using System;

namespace Maturita
{
    class Program
    {
        static void Tisk(int[]pole)
        {
            for (int i = 0; i < pole.Length;i++)
            {
                Console.Write($"{pole[i],5}");
            }
            Console.WriteLine();
        }
        static void Řazení(int[]pole)
        {
            int pom;
            for (int i = 1; i<pole.Length;i++)
            {
                for (int j =pole.Length-1; j>=i;j--)
                {
                    if (pole[j - 1] > pole[j])
                    {
                        pom = pole[j - 1];
                        pole[j - 1] = pole[j];
                        pole[j] = pom;
                    }
                }
                
            }Tisk(pole);
        }
        static void Main(string[] args)
        {
            int[] pole = { 10, 25, 3, 7, 6, 258, 4, 7 };
            Console.WriteLine("Bubble");
            pole = new int[] { 10, 25, 3, 7, 6, 258, 4, 7 };
            Tisk(pole);
            Řazení(pole);
            Console.WriteLine("\n\n\n");

        }
    }
}

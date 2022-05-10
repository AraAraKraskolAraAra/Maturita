using System;

namespace Maturita
{
    class Program
    {
        static void Tisk(int[]pole)
        {
            for(int k = 0; k < pole.Length;k++)
            {
                Console.Write("{0,5}" , pole[k]);
            }
            Console.WriteLine();
        }
        static void bubble(int[]pole)
        {
            int pom;
            for(int i = 1; i < pole.Length; i++)
            {
                for(int j = pole.Length-1; j >= i;j--)
                {
                    if(pole[j-1] > pole[j])
                    {
                        pom = pole[j - 1];
                        pole[j - 1] = pole[j];
                        pole[j] = pom;
                    }
                }Tisk(pole);
            }
            
        }
        static void Main(string[] args)
        {
            int[] pole = new int[] { 5, 10, 30, 100, 50, 1, 0 };
            Console.WriteLine(  "Bubble");
            pole = new int[] { 5, 10, 30, 100, 50, 1, 0 };
            Tisk(pole);
            bubble(pole);
            Console.WriteLine("\n\n\n");
        }
    }
}

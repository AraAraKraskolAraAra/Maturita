using System;

namespace Maturita
{
    class Program
    {
        static int[] VytvorPole()
        {
            int[] pole = new int[10];
            Random rng = new Random();
            for(int i = 0; i<10; i++)
            {
                pole[i] = rng.Next(1, 100);

            }
            return pole;
        }
        static void TiskPole(int[] pole)
        {
            for(int i = 0; i < pole.Length; i++)
            {
                Console.Write("{0}. {1} \n",i+1, pole[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] pole = VytvorPole();
            TiskPole(pole);
            Console.ReadLine();
        }
    }
}

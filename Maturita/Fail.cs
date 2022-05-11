using System;

namespace Maturita
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int[,] pole = new int[5,5];

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = rng.Next(1, 100);
                    Console.Write("{0}\t", pole[i, j]);


                }
                Console.WriteLine();
            }
                
                        ;

         
            

        }
    }
}

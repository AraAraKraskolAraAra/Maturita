using System;

namespace Maturita
{
    class Program
    {
        static void maximim(int[,] pole, int a, int max, int min)
        {
           
            
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    if (max < pole[i, j])
                    {
                        max = pole[i, j];
                    }
                    if (min > pole[i, j])
                    {
                        min = pole[i, j];
                    }
                }
            }
            Console.WriteLine("Maximum: {0} Minimum: {1}",max,min);
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            int[,] pole = new int[rng.Next(2,5), rng.Next(2, 5)];

            for(int i = 0; i < pole.GetLength(0); i++)
            {
;                for(int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = rng.Next(1, 100);
                    Console.Write("{0}\t",pole[i,j]);
                }
                Console.WriteLine();
            }
            int max = pole[0, 0];
            int min = pole[0, 0];
            int a = 0, b = 0,c = 0,d = 0;
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    if(max<pole[i,j])
                    {
                        max = pole[i, j];
                        a = i+1;
                        b = j+1;
                    }
                    if (min > pole[i, j])
                    {
                        min = pole[i, j];
                        c = i+1;
                        d = j+1;
                    }
                }
                
            }
            Console.WriteLine("Max: pole[{0},{1}] {2} Min: pole[{3},{4}] {5}",a,b,max,c,d,min);
            int r = rng.Next(1, 5);
            int t = rng.Next(1, 5);

            maximim(pole, pole.GetLength(0), max, min);

        }
    }
}

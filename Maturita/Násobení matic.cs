using System;

namespace Maturita
{
    class Program
    {

        static void Tisk(int[,]pole)
        {
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                 for (int j = 0; j < pole.GetLength(1); j++)
                {
                   
                    Console.Write("{0}\t", pole[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Soucin (int[,] X, int[,]Y)
        {
            int[,] Z = new int[X.GetLength(0), Y.GetLength(1)];

            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < Y.GetLength(1); j++)
                {
                    for (int k = 0; k < X.GetLength(1); k++)
                    {
                        Z[i, j] += X[i, k] * Y[k, j];
                        
                    }
                }
                Console.WriteLine();
            }
            Tisk(Z);
        }
        static void Main(string[] args)
        {
            
            int[,] poleA = new int[3,2];
            int[,] poleB = new int[2, 3];
            int a = 0;
            for (int i = 0; i < poleA.GetLength(0); i++)
            {
                 for (int j = 0; j < poleA.GetLength(1); j++)
                {
                    a++;
                    poleA[i, j] = a;
                }
                
            }
            a = 0;
            for (int i = 0; i < poleB.GetLength(0); i++)
            {
                 for (int j = 0; j < poleB.GetLength(1); j++)
                {
                    a++;
                    poleB[i, j] = a;
                    
                }
               
            }
            Tisk(poleA);
            Tisk(poleB);
            Soucin(poleB, poleA);
        }
    }
}

using System;

namespace Maturita
{
    class Program
    {
       public static Random rng = new Random();
       static void RozdílMeziBreACont()
        {
            for (int i = 0; i <= 10; i++)
            {
                if(i==8)
                {
                    break;
                }
                if(i==4)
                {
                    continue;
                }
                Console.WriteLine($"{i,5}");
                Console.WriteLine();
            }
        }
        static void Matice(int n, int m,int[,] mat)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = rng.Next(1, 10);
                    Console.Write($"{mat[i,j] , 5}");
                }
                Console.WriteLine();
            }

            if (m == n)
            {
                Console.WriteLine("Symetrie je krásná!!!");
            }
            else { Console.WriteLine("Víš co je to symetrie? Tohle fakt ne!"); }
        }

        static void Main(string[] args)
        {
            int[,] matice = new int[4, 3];

            RozdílMeziBreACont();
            Matice(matice.GetLength(0), matice.GetLength(1), matice);

            Console.ReadLine();


        }
    }
}

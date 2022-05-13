using System;

namespace Maturita
{
    class Program
    {
        public static int Determinant(int[,] mat)
        {
            int x = 0;

            x = (mat[0, 0] * mat[1, 1] * mat[2, 2] + mat[1, 0] * mat[2, 1] * mat[0, 2] + mat[2, 0] * mat[0, 1] * mat[1, 2])
             - (mat[0, 2] * mat[1, 1] * mat[2, 0] + mat[1, 2] * mat[2, 1] * mat[0, 0] + mat[2, 2] * mat[0, 1] * mat[1, 0]);

            return x;
        }
        static void Main(string[] args)
        {

            int[,] matice = new int[,]{{3,  -1, 0 },
                                       { -2, 1, 1 },
                                       { 2, -1,4 } };
            Console.WriteLine("{0}", Determinant(matice));
            int A = Determinant(matice);
            int[,] maticeX = new int[,]{{5,  -1, 0 },
                                       { 0, 1, 1 },
                                       { 15, -1,4 } };
            Console.WriteLine("{0}", Determinant(maticeX));
            int Ax = Determinant(maticeX);
            int[,] maticeY = new int[,]{{3,  5, 0 },
                                       { -2, 0, 1 },
                                       { 2, 15,4 } };
            Console.WriteLine("{0}", Determinant(maticeY));
            int Ay = Determinant(maticeY);
            int[,] maticeZ = new int[,]{{3,  -1, 5 },
                                       { -2, 1, 0 },
                                       { 2, -1,15 } };
            Console.WriteLine("{0}", Determinant(maticeZ));
            int Az = Determinant(maticeZ);

            int x = Ax / A;
            int y = Ay / A;
            int z = Az / A;
            Console.WriteLine("x = {0}\ny = {1}\nz = {2}", x, y, z);
        }
    }
}

using System;

namespace Maturita
{
    class Program
    {
        public delegate int MalaNeboVelkaCisla(int M);
        public delegate int MalaVelak(int m);
       

        public static Random rng = new Random();

        public static int MalyNeboVelky(int x)
        {
            if(x<50)
            {
                Console.WriteLine("{0} je malé",x);
            }
            else { Console.WriteLine($"{x} je velké"); }
            return x;
        }
         public static int Malaa(int x)
        {
            Console.WriteLine("{0} je málé číslo", x);
            return x;
        }
        public static int Velkaa(int x)
        {
           Console.WriteLine("{0} je velké číslo", x);
            return x;

        }



        static void Main(string[] args)
        {
            int a;
            a = rng.Next(1, 100);
            MalaNeboVelkaCisla MNV = new MalaNeboVelkaCisla(MalyNeboVelky);

            MalyNeboVelky(a);

           MalaVelak dell;

            dell = a < 50 ? new MalaVelak(Malaa) : new MalaVelak(Velkaa);
            dell(a);

        }
    }
}

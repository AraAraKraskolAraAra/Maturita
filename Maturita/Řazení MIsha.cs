using System;

namespace Maturita
{
    class Program
    {
        static bool HHH(int[] a, int[] b)
        {
            if (a.Length != b.Length)
            { return true; }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return true;
            }

            return false;
        }


        static void Výměna(ref int a, ref int b)
        {
            int pp;

            pp = a;
            a = b;
            b = pp;
        }
        static void Tisk(int[] pole)
        {
            for (int k = 0; k < pole.Length; k++)
            {
                Console.Write("{0,5}", pole[k]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            /* Napište program pro řazení jednorozměrného pole P celých čísel vzestupně
             * Použijte libovolný třídící algoritmus.
             */

            int[] pole = { 1, 2, 5, 10, 74, 8, 32, 16, 97, 13 };
            int[] pp = { 0 };
            int c = pole.Length - 1;

            do
            {
                pp = pole;



                for (int i = 1; i < pole.Length; i++)
                {
                    for (int j = c; j >= i; j--)
                    {

                     /*   if (pole[i] > pole[i + 1])
                        {
                            Výměna(ref pole[i], ref pole[i + 1]);
                        }*/
                        if (pole[j - 1] > pole[j])
                        {
                            Výměna(ref pole[j - 1], ref pole[j]);
                            Tisk(pole);
                        }
                    }
                }

                /*for (int j = c; j >= ; j--)
                {

                }*/

                Console.WriteLine();
                Tisk(pole);
            }
            while (HHH(pole, pp));

            Console.ReadLine();
        }
    }
}

using System;

namespace Maturita
{
    class Program
    {
        static void Main(string[] args)
        {
            string Výběr = "Ano";
            int C;
            char c = 'h';
            while( c != 'q' || c != 'Q')
            {
                Console.Write("Zadej VELKÉ písmeno: ");
                Výběr = Console.ReadLine();
                foreach(char b in Výběr)
                {
                    C = System.Convert.ToInt32(b);
                    if (65 > C || (C > 90 && C < 97) || C > 122)
                    {
                        Console.WriteLine("Ty si Pepega!");
                        continue;
                    }
                    if(C>64 && C<91)
                    { C += 32; }
                    else
                    { C = C - 32; }

                    Console.WriteLine(System.Convert.ToChar(C));

                    c = System.Convert.ToChar(C);

                    if (c == 'Q' || c == 'q')
                        Environment.Exit(0);
                }
            }
        }
    }
}

using System;
using System.IO;
namespace Maturita
{
    class Program
    {
        public static double poloměr(double d) 
        {
            double r = d / 2;
            return r;
        }
        public static double obvod (double d)
            {
            double r = d / 2;
            double o = 2 * Math.PI * d;
            return o;
            }
        public static double obsah (double d)
        {
            double r = d / 2;
            double S = Math.PI * r * r;
            return S;
        }



        static void Main(string[] args)
        {
            Console.Write("Zadejte průměr kruhu: ");
            double r = double.Parse(Console.qeadLine());

            poloměr(r);
            Console.WriteLine("Poloměr je: "+ poloměr(r) + " Obvod je: " + obvod(r) + " Obsah je: " + obsah(r));

            string curFile = @"C:\Users\sebas\OneDrive\Plocha\test.txt";
            Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");
            
            StreamReader sr = new StreamReader(curFile);
            char c;
            int C;
            while ((c = (char)sr.Read()) != -1)
            {
                C = System.Convert.ToInt32(c);
                if (C > 47 && C < 58)
                {
                    int a;
                    a = C - 48;
                    poloměr(a);
                    obsah(a);
                    obvod(a);
                    Console.WriteLine("Poloměr je: {0:F2} \tObvod je:  {1:F2} \tObsah je: {2:F2} ", poloměr(a), obsah(a), obvod(a) );

                }
                else { continue; }

                
            }
        }
    }
}

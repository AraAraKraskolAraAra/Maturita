using System;
using System.IO;

namespace Maturita
{
    class Program
    {
        static void Main(string[] args)
        {
            string curFile = @"C:\Users\sebas\OneDrive\Plocha\test.txt";
            Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");
            string curFile2 = @"C:\Users\sebas\OneDrive\Plocha\test2.txt";
            Console.WriteLine(File.Exists(curFile2) ? "File exists." : "File does not exist.");
            StreamReader sr = new StreamReader(curFile);
            StreamWriter sw = new StreamWriter(curFile2);
            char znak;
            int C;

             while((znak = (char)sr.Read()) != -1)
             {

                 C = System.Convert.ToInt32(znak);
                 if (C>64 && C <91)
                 {
                      C += 32;
                 
                 }
                if (C == 13)
                    continue;
                if (C == 32)
                    C = 0;
                 if(C > 47 && C < 58)
                 {
                     C -= C;
                 }
                
                 znak = System.Convert.ToChar(C);
                 sw.WriteLine(znak);
                 sw.Flush();
             }
           


        }
    }
}

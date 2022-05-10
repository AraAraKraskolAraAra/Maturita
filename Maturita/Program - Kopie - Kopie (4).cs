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
            Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");

            string q;
            int n = 0;
            
            
            using (StreamWriter sw= new StreamWriter(curFile2))
            {
                using (StreamReader sr = new StreamReader(curFile))
                {
                    while ((q = sr.ReadLine()) != null)
                    {
                        if(q == "")
                        {

                        }
                    }
                }
            }

            
            
        }
    }
}

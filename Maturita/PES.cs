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

            
            using (StreamReader sr = new StreamReader(curFile))
            {
                string c;
                int i = 0;
                string pes;
                int q = 0;
                
                while ((c = sr.ReadLine()) != null)
                {
                foreach(string p in c.Split('\t', '\n', ' '))
                    {
                        pes = p.ToLower();
                        if(pes == "pes")
                        {
                           i++;
                        } 
                        
                            if (c.StartsWith("t"))
                            {
                                q++;
                            }
                        if (c.EndsWith("t"))
                        {
                            continue;
                        }
                        else q--;
                           
                        
                    }
                Console.WriteLine(i);
                Console.WriteLine(q);
            }
                }
                

        }
    }
}

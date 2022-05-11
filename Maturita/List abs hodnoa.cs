using System;
using System.IO;
using System.Collections.Generic;
namespace Maturita
{
    class Program
    {
        static void Main(string[] args)
        {
            string curFile = @"C:\Users\sebas\OneDrive\Plocha\test.txt";
            Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");
            List<int> list = new List<int>();
            string num;
            using(StreamReader sr = new StreamReader(curFile))
            {
                while((num = sr.ReadLine())!=null)
                {
                    foreach(string p in num.Split(' ', '\n'))
                    {
                        if(p != "")
                        {
                            list.Add(Convert.ToInt32(p));
                        }
                    }
                }
                sr.Close();
            }
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] > 0)
                {
                    Console.WriteLine("{0}  \t: \t{1}", list[i], list[i]*2);
                }
                if (list[i] < 0)
                {
                    Console.WriteLine("{0}  \t: \t{1}", list[i], Math.Abs(list[i]));
                }
                if (list[i] == 0)
                {
                    Console.WriteLine("{0}  \t: \t{1}", list[i], list[i]);
                }
            }

            
        }
    }
}

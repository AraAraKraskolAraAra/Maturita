using System;
using System.Collections.Generic;

namespace Maturita
{
    class Program
    {
        public static List<int> TiskSeznamu(List<int> seznam)
        {
            foreach (int i in seznam)
            {
                Console.Write($"{i,5}");
            }

            return seznam;
        }
      public static List<int> VytvorPridanimNaKonec(int počet)
        {
            List<int> seznam = new List<int>();
            for(int i =0; i <= počet;i++)
            {
                seznam.Add(i);
            }
            return seznam;
        }
        public static List<int> VlozZa(List<int> seznam, int zaktery, int vkladany)
        {
            int index = seznam.IndexOf(zaktery);
            seznam.Insert(index + 1, vkladany);
            Console.WriteLine($"Prvek {zaktery} byl vložen za prvek {vkladany}");
            return seznam;
        }
        public static List<int> Změna(List<int> seznam, int nasobek)
        {
            Console.Write($"Všechna čísla byla vynásobena {nasobek}");
            Console.WriteLine();
            foreach(int a in seznam)
            {
                int b = a * 2;
                Console.Write($"{b,5}");
            }
            return seznam;
        }
       

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list = VytvorPridanimNaKonec(15);
            TiskSeznamu(list);
            Console.WriteLine();
            VlozZa(list, 5, 100);
            TiskSeznamu(list);
            Console.WriteLine();
            Změna(list, 2);
            Console.WriteLine();
           
            
        }
    }
}

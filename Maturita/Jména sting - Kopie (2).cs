using System;

namespace Maturita
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pole = new string[5];
           


            for(int i = 1; i <6; i++)
            {
                
                Console.Write($"Zadej {i}.jméno: ");
                pole[i - 1] = Console.ReadLine();
            }
            for( int j = 5; 0 <j;j--)
            {
                Console.Write(pole[j-1] + " ");
            }
            Console.ReadLine();

        }
    }
}

using System;

namespace Maturita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej velikost strany a trojúhelníku ABC: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Zadej velikost strany b trojúhelníku ABC: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Zadej velikost strany c trojúhelníku ABC: ");
            int c = int.Parse(Console.ReadLine());

            
            if(a + b < c || b + c < a || a + c < b)
            {
                Console.WriteLine("Trojúhelník neexistuje!");
            }    
            else
            {
                Console.WriteLine("Trojúhelník existuje!");
                if (c>b||c>a)
                {
                    
                    double O = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2));
                    if(c==O)
                    {
                        Console.WriteLine("Trojúhelník je pravoúhlý!");
                        
                    }
                   

                }
                if (b > c || b > a)
                {
                    
                    double O = Math.Sqrt(Math.Pow(c, 2) + Math.Pow(a, 2));
                    if (b == O)
                    {
                        Console.WriteLine("Trojúhelník je pravoúhlý!");
                    }
                    
                }
                if (a > b || a > c)
                {
                   
                    double O = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2));
                    if (a == O)
                    {
                        Console.WriteLine("Trojúhelník je pravoúhlý! a = {0,2:C}",a);
                    }
                   
                }
            }
        }
    }
}

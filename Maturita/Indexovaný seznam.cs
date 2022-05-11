using System;
using System.IO;
using System.Collections.Generic;
namespace Maturita
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> moto = new List<string> { "Jawa", "Honda", "Ducati","Kawasaki", "Suzuki", "BMW", "Yamaha" };

            int volba = 0;

            while(volba != -1)
            {
                Console.WriteLine("1. Foreach" +
                    "\n2. Vytiskne počet prvků a místo v paměti" +
                    "\n3. Index prvku Suzuki" +
                    "\n4. Smazání prvku BMW" +
                    "\n5. Přítomnost Hondy" +
                    "\n6. Ducati nahradit Indian" +
                    "\n7. Seřadit seznam" +
                    "\n8. Přidat BMW" +
                    "\n9. Pryč");

                Console.Write("Tvá volba: ");
                volba = int.Parse(Console.ReadLine());

                switch(volba)
                {
                    case 1:
                        foreach (string items in moto)
                        {
                            Console.WriteLine(items);
                        }
                        break;
                    case 2: Console.WriteLine("Počet prvků je {0} a kapacita {1}", moto.Count,moto.Capacity); break;
                    case 3:  Console.WriteLine("Index Suzuki je {0}",moto.IndexOf("Suzuki")); break;
                    case 4:
                        moto.Remove("BMW");
                        break;
                    case 5:
                        if(moto.IndexOf("Honda")!=0)
                        {
                            Console.WriteLine("Honda se nachází v seznamu s indexem {0}",moto.IndexOf("Honda"));
                        }
                        else { Console.WriteLine("Honda tu není!"); }
                        break;
                    case 6:
                        moto.Insert(moto.IndexOf("Ducati"), "Indian");
                        moto.Remove("Ducati");
                        break;
                    case 7:
                        moto.Sort();
                        break;
                    case 8:
                        moto.Add("BMW");
                        break;
                    case 9:
                        Environment.Exit(0);
                            break;
                    default: break;
                }
            }
            
        }
    }
}

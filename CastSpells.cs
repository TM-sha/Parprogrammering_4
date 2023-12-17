using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_4
{
    internal class CastSpells
    {
        public static void PerformMagic()
        {
            Console.Write("Skriv inn en trylleformel: ");
            string spell = Console.ReadLine();

            switch (spell.ToLower())
            {
                case "vingardium leviosa":
                    Console.WriteLine("\nDu får en fjær til å fly!\n");
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;
                case "hokus pokus":
                    Console.WriteLine("\nDu fyrer av fyrverkerier!\n");
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("\nUkjent trylleformel.\n");
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;
            }
            //ShowCharacter();
        }
    }
}

using System.Runtime.CompilerServices;

namespace Parprogrammering_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                var harry = ShowCharacter();
            }
        }

        private static void GoToShop(Character harry)
        {
            MagicShop magicShop = new MagicShop();

            magicShop.Menu();

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("\nYou bougth an owl");
                    harry.Inventory = harry.Inventory.Append("Owl").ToArray();
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("\nYou bougth a rat");
                    harry.Inventory = harry.Inventory.Append("Rat").ToArray();
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("\nYou bougth a cat");
                    harry.Inventory = harry.Inventory.Append("Cat").ToArray();
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("\nYou bougth a Dragonclaw");
                    harry.Inventory = harry.Inventory.Append("Dragonclaw").ToArray();
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                default:
                    break;
            }
            LeavingStore(harry);
        }

        private static void LeavingStore(Character harry)
        {
            Console.Write("Do you want to buy more items? y/n: ");
            if (Console.ReadLine() is "y" or "Y")
            {
                Console.Clear();
                GoToShop(harry);
            }
            else
            {
                Console.Write("\nDo you want to leave the store? y/n: ");
                if (Console.ReadLine() is "y" or "Y")
                {
                    Console.Clear();
                    Console.WriteLine("Leaving shop..\n");
                    Thread.Sleep(1500);
                    Console.WriteLine("Entering Hogwarths..\n");
                    Thread.Sleep(1500);
                    Console.Clear();
                    ShowInventory(harry);
                    PerformMagic();
                }
                else
                {
                    GoToShop(harry);
                }
            }
        }

        private static void ShowInventory(Character harry)
        {
            harry.Introduction();
            Console.ReadLine();
        }

        private static Character ShowCharacter()
        {
            Character harry = new Character
            {
                Name = "Harry Potter",
                House = "Gryffindor",
                Inventory = new string[] { }
            };
            harry.Introduction();

            Console.Write("Do you want to go to the magic shop? y/n: ");
            if (Console.ReadLine() is "y" or "Y")
            {
                Console.Clear();
                EnteringShop();
                GoToShop(harry);
            }
            else
            {
                Console.Write("\nDo you want to cast a spell? y/n: ");
                if (Console.ReadLine() is "y" or "Y")
                {
                    Console.Clear();
                    PerformMagic();
                }
            }
            return harry;
        }

        private static void EnteringShop()
        {
            Console.WriteLine("\nLeaving Hogwarts..\n");
            Thread.Sleep(1500);
            Console.WriteLine("Entering magic shop..\n");
            Thread.Sleep(1500);
            Console.Clear();
        }

        private static void PerformMagic()
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
            ShowCharacter();
        }
    }
}

/*Du skal starte med å lage en character klasse med egenskaper som navn, house, inventory (ex wand eller pet)
   
   Få applikasjonen til å printe ut en introduksjon for karakteren, som sier noe om hva de heter, hvilket hus de er medlem av og hvilke items de har
   
   Karakteren skal ha mulighet til å gå inn i en Magibutikk, der kan de kjøpe et dyr:  ugle, rotte eller en katt. De har også mulighet til å kjøpe en tryllestav. For å få til dette må du lage en egen klasse som er butikken, og presentere brukeren med en meny for hva personen skal kjøpe.
   
   Karakteren skal ha mulighet til å trylle - ta inn input fra brukeren, og dersom en skriver en riktig trylleformel skal det printes til skjermen at de har utført tryllingen
   trylleformler: 
   vingardium leviosa (får en fjær til å fly)
   hokus pokus (fyrer av fyrverkerier)*/
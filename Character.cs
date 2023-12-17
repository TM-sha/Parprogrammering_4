using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_4
{   class Character
    {
        public string Name { get; set; }
        public string House { get; set; }
        public string[] Inventory { get; set; }

        public void Introduction()
        {
            Console.WriteLine($"Hi, my name is {Name}, and I belong to {House}.");
            Console.WriteLine("My inventory:");
            foreach (var item in Inventory)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}

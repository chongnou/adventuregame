using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adventure
{
    class Forest
    {
        Random rnd = new Random();

        public Forest()
        {
            Exploring();
        }
        public int Exploring()
        {
            int look = rnd.Next(3);
            int milliseconds = 4000;

            Console.WriteLine("You look around the forest...");

            if (look == 0)
            {
                Console.WriteLine("\n\n Heck yea, you found treasure!");
                Console.WriteLine("\n\n Looting treasure...");
                Thread.Sleep(milliseconds);
                Console.Clear();
                Forest story = new Forest();
                
            }
            else if (look == 1)
            {
                Console.WriteLine("\n\n Oh no... a monster appear!");
                Console.WriteLine("\n\n Fighting monster...");
                Thread.Sleep(milliseconds);
                Console.Clear();
                Battle fight = new Battle();
            }
            else if (look == 2)
            {
                Console.WriteLine("\n\n You're lost! Better teleport back!");
                Console.WriteLine("\n\n Teleporting...");
                Thread.Sleep(milliseconds);
                Console.Clear();
                Adventure back = new Adventure();
            }
            return 0;
        }
    }
}

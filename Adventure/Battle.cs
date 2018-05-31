using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adventure
{
    class Battle
    {

        Random rnd = new Random();

        public Battle()
        {
            fight();
        }
        public int fight()
        {
            string userInput;
            int slash = rnd.Next(2);
            
            Console.WriteLine("Do you want to fight the monster or run away?");
            Console.WriteLine("Type 'fight' to fight. ");
            Console.WriteLine("Type 'run away' to run away");
            Console.ReadLine();
            userInput = Console.ReadLine();

            if (userInput == "fight")
            {

            }
            else if (slash == 1)
            {
                Console.WriteLine("\n\n You slash the monster with your sword Ha! Take that monster!");
            }
                
            else if (slash == 2)
            {
                Console.WriteLine("You try slashing the monster but missed! Try slashing again!");
            }

            return (0);
        }
    }
}

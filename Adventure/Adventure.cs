using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adventure
{
    class Adventure
    {
        public Adventure()
        {
            Explore();
        }


        public void Explore()
        {
            string userInput;
            
            Console.WriteLine("Would you like to enter the city or forest? Type city or forest: \n\n");
            userInput = Console.ReadLine();
            Console.Clear();

            if (userInput == "city")
            {
                Console.WriteLine("You've entered Arthur city.");
                Console.WriteLine("\n Arthur city was founded 20 years after the battle with the Horde.");
                Console.WriteLine("\n Press enter to continue. ");
                Console.ReadLine();
                Console.Clear();
                City city = new City();
            }
            else if (userInput == "forest")
            {
                Console.WriteLine("You've entered Elwynn Forest, don't get lost!\n\n");
                Forest search = new Forest();
            }
            else
            {
                Console.WriteLine("\n\n Invalid input, please try again.");
                Console.ReadLine();
                Console.Clear();
                Adventure back = new Adventure();

            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
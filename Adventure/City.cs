using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adventure
{
    class City
    {
        public City()
        {
            Explore();
        }

        public int Explore()
        {
            string userInput;

            Console.WriteLine("Welcome to the city, you can see the blacksmith/armorsmith to repair weapons/armor. ");
            Console.WriteLine("Or you can walk through the street to see the beautiful city.");
            Console.WriteLine("\n Type blacksmith for weapon repairs.");
            Console.WriteLine("\n Type armorsith for armor repairs.");
            Console.WriteLine("\n Type back to go back. ");

            userInput = Console.ReadLine();
            Console.Clear();

            if (userInput == "blacksmith")
            {
                Console.WriteLine("\n\n Hello, I am Argaloth, the blacksmith. I will repair your weapons here. \n\n");
                Console.WriteLine("Repairing weapons... \n\n");
                Thread.Sleep(3000);
                Console.WriteLine("Your weapons have been repaired... get slashin!");
                Console.WriteLine("\n Press enter to continue.");
                Console.ReadLine();
                Console.Clear();
                Adventure back = new Adventure();
            }
            else if (userInput == "armorsmith")
            {
                Console.WriteLine("\n\n Hello there, I am the armorsmith of this city, Blackhand, I will repair your armor. \n\n");
                Console.WriteLine("Repairing armor... \n\n");
                Thread.Sleep(3000);
                Console.WriteLine("Your armor has been repaired... get going!");
                Console.WriteLine("\n Press enter to continue.");
                Console.ReadLine();
                Console.Clear();
                Adventure back = new Adventure();
            }
            else if (userInput == "street")
            {
                Console.WriteLine("\n You walk through the street and remember your childhood memories...");
                Thread.Sleep(3000);
                Console.WriteLine("\n You snap out of it and continue walking.");
                Thread.Sleep(2000);
                Console.Clear();
                City back = new City();
            }
            else if (userInput == "back")
            {
                Adventure back = new Adventure();
            }
            else
            {
                Console.WriteLine("\n Invalid input, please try again");
                Console.ReadLine();
                Console.Clear();
                City back = new City();
            }

            return 0;
        }
    }
}

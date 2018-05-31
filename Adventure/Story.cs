using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adventure
{
    class Story
    {
        public Story()
        {
            Greetings();
        }


        public void Greetings()
        {
            
            Console.WriteLine("Welcome to revenge rpg!\n");
            Console.WriteLine("You are Baron, son of Baron the First! Your family was murdered by Falric, your evil cousin.");
            Console.WriteLine("Your mother hid you while your family was slaughtered and ");
            Console.WriteLine("your most trusted caretaker found you, to raise you... to take revenge...");
            Console.WriteLine("You must get revenge and restore order to the Kingdom...");
            Console.WriteLine("\n Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            Adventure jounrey = new Adventure();
        }
    }
}

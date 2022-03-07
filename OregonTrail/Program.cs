using System;

namespace OregonTrail
{
    class Program
    {
        static void Main(string[] args)
        {

            //player has to make a name for themself, then guided to inn.
            Console.WriteLine("Hey there! I dont believe we've met.");
            Console.WriteLine("I'm Sheriff Snoke. What's your name?");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            string playerName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Well, nice to meet you " + playerName + ". Since you're new here let me point you in the right direction.");
            Console.WriteLine("That building right there is the Inn. Head straight there he'll help you with anything you need.");
            Console.WriteLine(" ");
            Console.WriteLine("Push any key to go to inn");
            Console.ReadLine();




            // Inventory (the items carried on person)
            double money;

            //Store (items for sale)



            //Wagon (items on buggie)


            Console.Clear();
            Console.WriteLine("Hello, Welcome to the Trailblazer's Inn!\n");
            Console.WriteLine("A start point for many explorers looking to make a name for themselves.");
            Console.WriteLine("The journey ahead is full of risks and rewards as you make your journey West!");
            Console.WriteLine("I hope you enjoy your night here as we load your horse with supplies.\n");
            Console.WriteLine("In the morning you will start out on your journey into the new land!");
        }
    }
}
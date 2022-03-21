using System;

namespace OregonTrail
{
    class Program
    {

        static void Main(string[] args)
        {




            // Inventory (the items carried on person)
           // double money;

            //Store (items for sale)



            //Wagon (items on buggie)



            //Meet the Sheriff
            //player has to create a name for themself, then guided to inn.
            Console.WriteLine("Hey there weary traveler! I dont believe we've met.");
            Console.WriteLine("I'm Sheriff Snoke. What's your name?\n\n");

            string playerName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Well, nice to meet you " + playerName + ". Since you're new here let me point you in the right direction.");
            Console.WriteLine("That building right there is the Inn. Head straight there Connor willl help you with anything you need.\n");
            Console.WriteLine("Push ENTER to go to inn\n");
            Console.ReadLine();


            //Meet the inn keeper and continue to the store


            Console.Clear();
            Console.WriteLine("Hello, Welcome to the Trailblazer's Inn!\n");
            Console.WriteLine("A start point for many explorers looking to make a name for themselves.");
            Console.WriteLine("The journey ahead is full of risks and rewards as you make your journey West!");
            Console.WriteLine("I hope you enjoy your night here as we load your horse with supplies.\n");
            Console.WriteLine("In the morning you will start out on your journey into the new land!\n\n");
            Console.WriteLine("Push ENTER to rest and walk to the store.\n\n");
            Console.ReadLine();



            // Player gets to purchase items before heading on adventure

            Console.Clear();
            Console.WriteLine("Howdy " + playerName + "! Welcome to the Journeyman's Mercantile." +
                " There's a large selection of item. \nChoose what you like.\nEhem...\nFor the right price that is.\n\n");
            Console.Write("Enter the item you'd like to purchase\n\n  #1: Food\n\n  #2: Ammo\n\n  #3: Repair kit\n\n\n");
            


            //create a loop that allows the user to buy more than one item.

            bool doneViewingStoreItems = false;

            while (!doneViewingStoreItems) {
                string playerResponse = Console.ReadLine();
                if (playerResponse == "1")
                {
                    Console.WriteLine("You have entered the number 1");
                }
                else if (playerResponse == "2")
                {
                    Console.WriteLine("You have chosen 2");
                }
                else if (playerResponse == "3")
                {
                    Console.WriteLine("You have chosen 3");
                }
                else if (playerResponse == "4")
                {
                    Console.WriteLine("You have chosen 4");
                }
                else if (playerResponse == "exit")
                {
                    Console.WriteLine("Exiting store");
                    Console.ReadLine();
                    doneViewingStoreItems = true;
                }
                else
                {
                    Console.WriteLine("That's not an item in the store. Please choose again");
                }
            }

            //  Use "IF" statement to find the selection the user made

            

            Console.ReadLine();


        }
    }
}
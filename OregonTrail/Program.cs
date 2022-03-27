using System;

namespace OregonTrail
{
    class Program
    {

        static void Main(string[] args)
        {
<<<<<<< HEAD

=======
            PlayerDamage();
            PlayerDamage();
            PlayerDamage();
            PlayerDamage();
            PlayerDamage();
>>>>>>> cff727af3ff9961a31f5f3f05ec7376024010f62
            // Inventory (the items carried on person)
            // double money;

            //Store (items for sale)



            //Wagon (items on buggie)

            //Create player character


            //Meet the Sheriff, who will ask your character's name

            Console.WriteLine("Hey there weary traveler! I dont believe we've met.");
            Console.WriteLine("I'm Sheriff Snoke. What's your name?\n\n");

            //create and store name for playable charcter
            Player player = new Player()
            {
                Name = Console.ReadLine()
            };

            Console.Clear();
            Console.WriteLine("Well, nice to meet you " + player.Name + ". Since you're new here let me point you in the right direction.");
            Console.WriteLine("That building right there is the Inn. Head straight there Connor willl help you with anything you need.\n");
            Console.WriteLine("Push ENTER to go to inn\n");
            Console.ReadLine();


            //Meet the inn keeper and continue to the store

            //motis engineering recruting ge appliances software qa engineer tester They are a placer company for GE.


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
            Console.WriteLine("Howdy " + player.Name + "! Welcome to the Journeyman's Mercantile." +
                " There's a large selection of item. \nChoose what you like.\nEhem...\nFor the right price that is.\n\n");
            Console.Write("Enter the item you'd like to purchase\n\n  #1: Food\n  #2: Ammo\n  #3: Repair kit\n" +
                "  #4: Lever Action Rifle\n\n exit: Leave store\n\n\n");



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


        }

        /// <summary>
        /// This is the method generator for how much damage an enemy will do per turn.
        /// </summary>
        static void EnemyDamage()
        {
            //Number generator for a random number
            Random damageGen = new Random();
            int damageQuantity = damageGen.Next(5, 10);
            Console.WriteLine(damageQuantity);
        }

        /// <summary>
        /// This is the method that generates damage dealt by the playable character
        /// </summary>
        static void PlayerDamage()
        {
            Random playerDamageGen = new Random();
            int playerDamageQuantity = playerDamageGen.Next(35, 60);

            //This generates a value that can be used to determain if the player strikes with a critical strike
            
            Random critDamageGen = new Random();
            int critValue = critDamageGen.Next(0, 100);

            //This is how you decide the odds of Critically striking and the multiplier for the crit strike

            if (critValue >= 75)
            {
                playerDamageQuantity = playerDamageQuantity * 2;
            }

            Console.WriteLine(playerDamageQuantity);
            
        }
    }

}
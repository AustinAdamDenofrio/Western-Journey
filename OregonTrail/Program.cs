using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OregonTrail
{

    



    class Program
    {

        static void Main(string[] args)
        {
            PlayerReview();
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

            //Game introduction

            Console.Clear();
            Console.WriteLine("Well, nice to meet you " + player.Name + ". Since you're new here let me point you in the right direction.");
            Console.WriteLine("That building right there is the Inn. Head straight there Connor will help you with anything you need.\n");
            Console.WriteLine("Push ENTER\n");
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
                " There's a large selection of items. \nChoose what you like.\nEhem...\nFor the right price that is of course.\n\n");



            //create a loop that allows the user to buy more than one item.

            bool doneViewingStoreItems = false;

            while (!doneViewingStoreItems)
            {
                Console.Write("Enter the item you'd like to purchase\n\n  #1: Crate of Food\n  #2: Ammo\n  #3: Lever Action Rifle\n" +
                    "  #4: Bourbon\n\n exit: Leave store\n\n\n");

                string playerResponse = Console.ReadLine();
                if (playerResponse == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Do you want to purchase a crate of food supplies?\n(y)\n(n)\n\n\n");

                    //This loop confirms that the player wishes to purchase item

                    bool playerHasDecided = false;
                    while (!playerHasDecided)
                    {
                        string playerChoice = Console.ReadLine();
                        if (playerChoice == "y")
                        {
                            Console.WriteLine("These will come in handy. Man's got to eat!");
                            playerHasDecided = true;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (playerChoice == "n")
                        {
                            Console.WriteLine("I have enough food for now");
                            playerHasDecided = true;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("What? That doesn't make sense... Try again\n\nType (y) to confirm purchase\nor (n) to cancel\n\n");
                            Console.WriteLine("Do you want to purchase a crate of food supplies?\n(y)\n(n)\n\n\n");
                        }
                    }

                }
                else if (playerResponse == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Do you want to purchase a box of ammo?\n(y)\n(n)\n\n\n");

                    //This loop confirms that the player wishes to purchase item

                    bool playerHasDecided = false;
                    while (!playerHasDecided)
                    {
                        string playerChoice = Console.ReadLine();
                        if (playerChoice == "y")
                        {
                            Console.WriteLine("Love the smell of gun powder in the air. Thank you!");
                            playerHasDecided = true;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (playerChoice == "n")
                        {
                            Console.WriteLine("I guess I there's such a thing as buying too much ammo");
                            playerHasDecided = true;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("What? That doesn't make sense... Try again\n\nType (y) to confirm purchase\nor (n) to cancel\n\n");
                            Console.WriteLine("Do you want to purchase a box of ammo?\n(y)\n(n)\n\n\n");
                        }
                    }
                }
                else if (playerResponse == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Do you want to purchase a new rifle?\n(y)\n(n)\n\n\n");

                    //This loop confirms that the player wishes to purchase item

                    bool playerHasDecided = false;
                    while (!playerHasDecided)
                    {
                        string playerChoice = Console.ReadLine();
                        if (playerChoice == "y")
                        {
                            Console.WriteLine("This is the difference between life and death on the trail");
                            playerHasDecided = true;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (playerChoice == "n")
                        {
                            Console.WriteLine("Oops, I meant to point to the ammo! I guess I should lay off the bourbon, huh?");
                            playerHasDecided = true;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("What? That doesn't make sense... Try again\n\nType (y) to confirm purchase\nor (n) to cancel\n\n");
                            Console.WriteLine("Do you want to purchase a new rifle?\n(y)\n(n)\n\n\n");
                        }
                    }
                }
                else if (playerResponse == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Do you want to purchase a bottle of bourbon?\n(y)\n(n)\n\n\n");

                    //This loop confirms that the player wishes to purchase item

                    bool playerHasDecided = false;
                    while (!playerHasDecided)
                    {
                        string playerChoice = Console.ReadLine();
                        if (playerChoice == "y")
                        {
                            Console.WriteLine("You would not believe how hard this is to make while traveling!");
                            playerHasDecided = true;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (playerChoice == "n")
                        {
                            Console.WriteLine("I think thats all I need");
                            playerHasDecided = true;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("What? That doesn't make sense... Try again\n\nType (y) to confirm purchase\nor (n) to cancel\n\n");
                            Console.WriteLine("Do you want to purchase a bottle of bourbon?\n(y)\n(n)\n\n\n");
                        }
                    }
                }
                else if (playerResponse == "exit")
                {
                    Console.WriteLine("Leaving Journeyman's Mercantile");
                    Console.ReadLine();
                    doneViewingStoreItems = true;
                }
                else
                {
                    Console.WriteLine("That's not an item in the store. Please choose again");
                }
            }


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
        } //End of EmemyDamage Method
        


        /// <summary>
        /// This is the method that generates damage dealt by the playable character
        /// </summary>
        static void PlayerDamage()
        {
            Random playerDamageGen = new Random();
            int playerDamageQuantity = playerDamageGen.Next(35, 60);

            //Tbhis generates a value that can be used to determain if the player strikes with a critical strike

            Random critDamageGen = new Random();
            int critValue = critDamageGen.Next(0, 100);

            //This is how you decide the odds of Critically striking and the multiplier for the crit strike

            if (critValue >= 75)
            {
                playerDamageQuantity = playerDamageQuantity * 2;
            }

            Console.WriteLine(playerDamageQuantity);
        } //End of PlayerDamage Method


        /// <summary>
        /// This method asks the player to rate the game experience then prints their answers to a JSON file.
        /// </summary>
        static void PlayerReview()
        {
            Reviews reviews = new Reviews()
            {
                GamerName = "DSAs",
                GameRating = 10,
                Comments = "Insert text"

            };
            string strJsonReviewFile = JsonConvert.SerializeObject(reviews);
            Console.WriteLine(strJsonReviewFile);
        }


    } //End Class Program 

} //End Namespace
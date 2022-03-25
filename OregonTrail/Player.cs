using System;
namespace OregonTrail
{
    /// <summary>
    /// This is class is the playable main character of the game.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Name of Playable Character
        /// </summary>
        public string Name { get; set; }

        public int Health { get; set; }

        public int Hunger { get; set; }


        /// <summary>
        /// Default Constructor
        /// </summary>
        public Player()
        {
            //Setting the health value to 100
            Health = 100;
        }
    }
}

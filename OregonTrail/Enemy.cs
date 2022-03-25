using System;
namespace OregonTrail
{

    public class Enemy
    {
        /// <summary>
        /// The quantity of health of the enemy
        /// </summary>
        public int Health { get; set; }
        /// <summary>
        /// The Enemy name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Determains if enemy is dead or alive
        /// </summary>
        public bool IsDead { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="name">The name we give to the enemy</param>

        public Enemy(string name)
        {

            //Default health for an enemy

            Health = 100;

            //sets the enemy's name

            Name = name;

        }
    }
}

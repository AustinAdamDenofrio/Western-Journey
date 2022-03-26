using System;
namespace OregonTrail
{
    public class Bear : Enemy
    {
        public Bear() : base("Grizzly Bear")
        {
            // The health is a higher value than ordinary enemy

            Health = 125;

            // The bear name

            Name = "Great Brown Bear";
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    /// This class represents a rainbow stacker that inherits from Toy
    /// </summary>
    public class ToyRainbowStacker : Toy
    {
        // Property that holds how many Rings the stacker has
        public int RingCount { get; set; }
        // Property that holds if you can stack the rings
        public bool IsStackable { get; set; }
        // Property that determines if its a full ring or half circles
        public bool IsRing { get; set; }

        public ToyRainbowStacker(double cost, string description, string name, 
            string manufacturingCompany, int manufacturedYear, int minimumAge, int maximumAge, bool chokingHazard, int weight) 
            : base(cost, description, name, manufacturingCompany, manufacturedYear, minimumAge, maximumAge, chokingHazard, weight)
        {
            this.RingCount = 12;
            this.IsStackable = true;
            this.IsRing = false;
        }
        /// <summary>
        /// Displays a message saying that the rainbow stacked was knocked over
        /// </summary>
        public void KnockMeOver()
        {
            Console.WriteLine("You've knocked over the rainbow stacker over");
        }
        /// <summary>
        /// Displays a message saying that you have stacked the rainbow stacker
        /// </summary>
        public void Stack()
        {
            Console.WriteLine($"You've stacked the {this.RingCount} item rainbow stacker");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    /// Represents a toy car that inherits from Toy
    /// </summary>
    public class ToyCar : Toy
    {
        // Property that tracks how many wheels the toy car will have
        public int AmountOfWheels { get; set; }
        // Property that provides true or false based on if the toy cars wheels function
        public bool HasWorkingWheels { get; set; }
        // Property that determines if the toy car is remote controlled or not
        public bool IsRcCar { get; set; }

        public ToyCar(double cost, string description, string name, string manufacturingCompany, int manufacturedYear, 
            int minimumAge, int maximumAge, bool chokingHazard, int weight) : 
            base(cost, description, name, manufacturingCompany, manufacturedYear, minimumAge, maximumAge, chokingHazard, weight)
        {
            this.AmountOfWheels = 4;
            this.HasWorkingWheels = true;
            this.IsRcCar = true;
        }
        /// <summary>
        /// When called on a toy car object will determine if it has working and wheels and is an rc car
        /// Depending on what is true will either display a message saying car moved forward with your hands / remote or car doesn't move
        /// </summary>
        public void MoveForward()
        {
            if (this.HasWorkingWheels == true && this.IsRcCar == true)
            {
                Console.WriteLine($"You moved the car forward using the remote");
            }
            else if(this.HasWorkingWheels == true && this.IsRcCar == false)
            {
                Console.WriteLine($"You moved the car forward using your hands");
            }
            else
            {
                Console.WriteLine("The car doesn't move");
            }
        }
        /// <summary>
        /// When called on a toy car object will determine if it has working and wheels and is an rc car
        /// Depending on what is true will either display a message saying car moved backwards with your hands / remote or car doesn't move
        /// </summary>
        public void MoveBackwards()
        {
            if (this.HasWorkingWheels == true && this.IsRcCar == true)
            {
                Console.WriteLine($"You moved the car backwards using the remote");
            }
            else if (this.HasWorkingWheels == true && this.IsRcCar == false)
            {
                Console.WriteLine($"You moved the car backwards using your hands");
            }
        }
    }
}

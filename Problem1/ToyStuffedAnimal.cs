using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    /// Represents a stuffed animal inherits from Toy
    /// </summary>
    public class ToyStuffedAnimal : Toy
    {
        // Property that holds the type of stuffing the stuffed animal has
        public string TypeOfStuffing { get; set; }
        // Property that holds the type of fabric the stuffed animal has
        public string TypeOfFabric { get; set; }
        // Property that holds the type of animal the stuffed animal is made to resemble
        public string TypeOfAnimal { get; set; }
        public ToyStuffedAnimal(double cost, string description, string name, string manufacturingCompany, 
            int manufacturedYear, int minimumAge, int maximumAge, bool chokingHazard, int weight) 
            : base(cost, description, name, manufacturingCompany, manufacturedYear, minimumAge, maximumAge, chokingHazard, weight)
        {
            this.TypeOfStuffing = "Cotton";
            this.TypeOfFabric = "Silk";
            this.TypeOfAnimal = "Spider";
        }
        /// <summary>
        /// This method displays a message about laying still
        /// </summary>
        public void LayThere()
        {
            Console.WriteLine($"I'm a {this.TypeOfAnimal} stuffed animal so I just lay around waiting for my prey");
        }
        /// <summary>
        /// This method displays a message about looking cute
        /// </summary>
        public void LookCute()
        {
            Console.WriteLine($"I'm made of {this.TypeOfFabric} and i'm full of {TypeOfStuffing} so I look cute");
        }
    }
}

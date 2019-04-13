using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    /// Represents a toydollhouse and it inherits from toy
    /// </summary>
    public class ToyDollhouse : Toy
    {
        // Holds how many rooms the dollhouse has
        public int NumberOfRooms { get; set; }
        // Holds what furniture style the dollhouse has
        public string FurnitureStyle { get; set; }
        // Holds how many floors the dollhouse has
        public int HowManyFloors { get; set; }
        public ToyDollhouse(double cost, string description, string name, string manufacturingCompany, 
            int manufacturedYear, int minimumAge, int maximumAge, bool chokingHazard, int weight) 
            : base(cost, description, name, manufacturingCompany, manufacturedYear, minimumAge, maximumAge, chokingHazard, weight)
        {
            this.NumberOfRooms = 15;
            this.FurnitureStyle = "Gothic";
            this.HowManyFloors = 4;
        }
        /// <summary>
        /// Displays a message saying you opened the dollhouse
        /// </summary>
        public void OpenHouse()
        {
            Console.WriteLine($"You've opened the {this.HowManyFloors} floor dollhouse");
        }
        /// <summary>
        /// Displays a message saying you closed the dollhouse
        /// </summary>
        public void CloseHouse()
        {
            Console.WriteLine($"You've closed the dollhouse with {this.FurnitureStyle} styled furniture and {this.NumberOfRooms}");
        }
    }
}

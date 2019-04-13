using System;

namespace Problem1
{
    /// <summary>
    /// Abstract toy class that represents what properties all classes that inherit from the toy class must have
    /// </summary>
    public abstract class Toy
    {
        public double Cost { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string ManufacturingCompany { get; set; }
        public int ManufacturedYear { get; set; }
        public int MinimumAge { get; set; }
        public int MaximumAge { get; set; }
        public bool ChokingHazard { get; set; }
        public int Weight { get; set; }
        public Toy(double cost, string description, string name, string manufacturingCompany, 
            int manufacturedYear, int minimumAge, int maximumAge, bool chokingHazard, int weight)
        {
            this.Cost = cost;
            this.Description = description;
            this.Name = name;
            this.ManufacturingCompany = manufacturingCompany;
            this.ManufacturedYear = manufacturedYear;
            this.MinimumAge = minimumAge;
            this.MaximumAge = maximumAge;
            this.ChokingHazard = chokingHazard;
            this.Weight = weight;
        }
    }
}

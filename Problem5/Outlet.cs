using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5
{
    /// <summary>
    /// Represents an outlet that can be plugged into
    /// </summary>
    public class Outlet
    {
        public string Type { get; set; }
        public int ProngCount { get; set; }
        public double Amperage { get; set; }
        public double Voltage { get; set; }
        public bool IsPolarized { get; set; }

        /// <summary>
        /// Creates a new outlet
        /// </summary>
        /// <param name="type">What type of Outlet it is A,B,C,D,E (etc)</param>
        /// <param name="prongCount">How many prongs the socket has</param>
        /// <param name="amperage">How many amps the socket provides</param>
        /// <param name="voltage">How much voltage the socket provides</param>
        /// <param name="isPolarized">Is it grounded</param>
        public Outlet(string type, int prongCount, double amperage, double voltage, bool isPolarized)
        {
            this.Type = type;
            this.ProngCount = prongCount;
            this.Amperage = amperage;
            this.Voltage = voltage;
            this.IsPolarized = isPolarized;
        }
    }
}

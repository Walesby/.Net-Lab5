using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5
{
    public class Outlet
    {
        public string Type { get; set; }
        public int ProngCount { get; set; }
        public double Amperage { get; set; }
        public double Voltage { get; set; }
        public bool IsPolarized { get; set; }
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

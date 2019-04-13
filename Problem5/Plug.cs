using Problem5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5
{
    /// <summary>
    /// Represents a Plug that will be plugged into an outlet
    /// </summary>
    public class Plug
    {
        public string Type { get; set; }
        public int ProngCount { get; set; }
        public double Amperage { get; set; }
        public double Voltage { get; set; }
        public bool IsPolarized { get; set; }
        public bool IsRecievingElectricity { get; set; }

        /// <summary>
        /// Creates a new plug
        /// </summary>
        /// <param name="type">What type of Plug it is A,B,C,D,E (etc)</param>
        /// <param name="prongCount">How many prongs the plug has</param>
        /// <param name="amperage">How many amps the plug provides</param>
        /// <param name="voltage">How much voltage the plug provides</param>
        /// <param name="isPolarized">Is it grounded</param>
        public Plug(string type, int prongCount, double amperage, double voltage, bool isPolarized)
        {
            this.Type = type;
            this.ProngCount = prongCount;
            this.Amperage = amperage;
            this.Voltage = voltage;
            this.IsPolarized = isPolarized;
            this.IsRecievingElectricity = false;
        }

        /// <summary>
        /// Method attempts to plug into the provided outlet and if they are the same types does
        /// Otherwise it makes an adapter and connects to the outlet through the adapter
        /// </summary>
        /// <param name="outlet"></param>
        public void PlugIn(Outlet outlet)
        {
            if (this.Type.Equals(outlet.Type))
            {
                this.IsRecievingElectricity = true;
            }
            else if (!this.Type.Equals(outlet.Type))
            {
                IPlugAdapter adapter = new Adapter(this);
                adapter.Connect(outlet);
                this.IsRecievingElectricity = true;
            }
        }

        /// <summary>
        /// Method unplugs the plug from the outlet
        /// </summary>
        public void UnPlug()
        {
            this.IsRecievingElectricity = false;
        }
    }
}

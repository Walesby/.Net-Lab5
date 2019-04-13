using Problem5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5
{
    public class Plug
    {
        public string Type { get; set; }
        public int ProngCount { get; set; }
        public double Amperage { get; set; }
        public double Voltage { get; set; }
        public bool IsPolarized { get; set; }
        public bool IsRecievingElectricity { get; set; }
        public Plug(string type, int prongCount, double amperage, double voltage, bool isPolarized)
        {
            this.Type = type;
            this.ProngCount = prongCount;
            this.Amperage = amperage;
            this.Voltage = voltage;
            this.IsPolarized = isPolarized;
            this.IsRecievingElectricity = false;
        }
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
        public void UnPlug()
        {
            this.IsRecievingElectricity = false;
        }
    }
}

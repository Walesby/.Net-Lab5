using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Represents a computer assembled by the ComputerBuilder class
    /// </summary>
    public class Computer
    {
        public HardDrive HardDrive { get; set; }
        public Motherboard MotherBoard { get; set; }
        public Case Case { get; set; }
        public override string ToString()
        {
            return $"Cpu: {MotherBoard.Cpu}, Graphics Card: {MotherBoard.GraphicsCard}, Hard Drive {HardDrive}, Memory {MotherBoard.Memory}, Motherboard {MotherBoard}, Case {Case}";
        }
    }
}

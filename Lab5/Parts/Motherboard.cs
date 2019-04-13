using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Represents the Motherboard of a computer
    /// </summary>
    public class Motherboard
    {        
        public int MemorySlots { get; set; }
        public double PowerConsumption { get; set; }
        public int PciSlots { get; set; }
        public string FormFactor { get; set; }
        public int HardDriveLimit { get; set; } 
        // Holds a Cpu Object that will be added by the ComputerBuilder
        public Cpu Cpu { get; set; }
        // Holds a Memory Object that will be added by the ComputerBuilder
        public Memory Memory { get; set; }
        // Holds a GraphicsCard Object that will be added by the ComputerBuilder
        public GraphicsCard GraphicsCard { get; set; }
        /// <summary>
        /// Creates a new Motherboard Object
        /// </summary>
        /// <param name="memorySlots">How many slots for memory the motherboard has</param>
        /// <param name="powerConsumption">How much power the motherboard consumes</param>
        /// <param name="pciSlots">How many pci slots the motherboard can have plugged in</param>
        /// <param name="formFactor">What form factor the motherboard is</param>
        /// <param name="hardDriveLimit">How many hard drives can be attached to the motherboard at one time</param>
        public Motherboard(int memorySlots, double powerConsumption, int pciSlots, string formFactor, int hardDriveLimit)
        {
            // If all inputs are good it will create a new Motherboard with the provided information
            if (memorySlots > 0 && powerConsumption > 0 && pciSlots > 0 && hardDriveLimit > 0)
            {
                this.MemorySlots = memorySlots;
                this.PowerConsumption = powerConsumption;
                this.PciSlots = pciSlots;
                this.FormFactor = formFactor;
                this.HardDriveLimit = hardDriveLimit;
            }
            // If any of the inputs are invalid it will throw an exception with a message based on which input was invalid
            else
            {
                if (memorySlots <= 0)
                {
                    throw new Exception(string.Format("Your motherboard must have more than 0 memory slots"));
                }
                else if (powerConsumption <= 0)
                {
                    throw new Exception(string.Format("Your motherboard power consumption must be more than 0"));
                }
                else if (pciSlots <= 0)
                {
                    throw new Exception(string.Format("Your motherboard must have more than 0 pci slots"));
                }
                else if (hardDriveLimit <= 0)
                {
                    throw new Exception(string.Format("Your motherboard must be able to have more than 0 hard drives attached to it"));
                }
            }
        }
    }
}

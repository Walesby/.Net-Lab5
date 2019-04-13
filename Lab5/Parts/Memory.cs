using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Represents the Memory of a computer (RAM)
    /// </summary>
    public class Memory
    {      
        public int ReadSpeed { get; set; }
        public int WriteSpeed { get; set; }
        public string Type { get; set; }
        public int MemoryAmount { get; set; }
        public Memory(int readSpeed, int writeSpeed, string type, int memoryAmount)
        {
            // Determines if all inputs are realistic
            if (readSpeed > 0 && writeSpeed > 0 && memoryAmount > 0)
            {
                this.ReadSpeed = readSpeed;
                this.WriteSpeed = writeSpeed;
                this.Type = type;
                this.MemoryAmount = memoryAmount;
            }
            // If any of the inputs are invalid it will throw an exception with a message based on which input was invalid
            else
            {
                if (readSpeed <= 0)
                {
                    throw new Exception(string.Format("Your read speed must be greater than 0"));
                }
                else if (writeSpeed <= 0)
                {
                    throw new Exception(string.Format("Your write speed must be greater than 0"));
                }
                else if (memoryAmount <= 0)
                {
                    throw new Exception(string.Format("Your memory amount must be greater than 0"));
                }
            }
        }
    }
}

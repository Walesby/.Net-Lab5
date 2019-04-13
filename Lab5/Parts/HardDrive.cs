using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Represents a Hard Drive of a computer
    /// </summary>
    public class HardDrive
    {       
        public int Capacity { get; set; }
        public string Type { get; set; }
        public int ReadSpeed { get; set; }
        public int WriteSpeed { get; set; }
        public HardDrive(int capacity, string type, int readSpeed, int writeSpeed)
        {
            // Determines if all inputs are realistic
            if (capacity > 0 && readSpeed > 0 && writeSpeed > 0)
            {
                this.Capacity = capacity;
                this.Type = type;
                this.ReadSpeed = readSpeed;
                this.WriteSpeed = writeSpeed;
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
                else if (capacity <= 0)
                {
                    throw new Exception(string.Format("Your capacity must be greater than 0"));
                }
            }
        }
    }
}

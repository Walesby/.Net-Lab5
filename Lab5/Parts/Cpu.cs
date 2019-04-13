using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Represents a CPU of a Computer
    /// </summary>
    public class Cpu
    {       
        public double ClockSpeed { get; set; }
        public string Manufacturer { get; set; }
        public string SocketType { get; set; }
        public int CacheSize { get; set; }
        public int AmountOfCores { get; set; }
        public Cpu(double clockSpeed, string manufacturer, string socketType, int cacheSize, int amountOfCores)
        {
            // Determines if all inputs are realistic
            if (clockSpeed > 0 && cacheSize > 0 && amountOfCores > 0)
            {
                this.ClockSpeed = clockSpeed;
                this.Manufacturer = manufacturer;
                this.SocketType = socketType;
                this.CacheSize = cacheSize;
                this.AmountOfCores = amountOfCores;
            }
            // If any of the inputs are invalid it will throw an exception with a message based on which input was invalid
            else
            {
                // If clock speed is less than zero it will throw an exception because the clock speed of a CPU can't be less than 0
                if (clockSpeed <= 0)
                {
                    throw new Exception(string.Format("Your cpu clock speed must be greater than 0"));
                }
                // If cache size is less than zero it will throw an exception because the cache size of a CPU can't be less than 0
                else if (cacheSize <= 0)
                {
                    throw new Exception(string.Format("Your cache size must be greater than 0"));
                }
                // If the amount of cores is less than zero it will throw an exception because the amount of cores a CPU has can't be less than 0
                else if (amountOfCores <= 0)
                {
                    throw new Exception(string.Format("Your amount of cores must be greater than 0"));
                }
            }
        }
    }
}

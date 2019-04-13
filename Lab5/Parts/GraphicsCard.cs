using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Represents a Graphics Card of a Computer
    /// </summary>
    public class GraphicsCard
    {       
        public int FanCount { get; set; }
        public double Speed { get; set; }
        public int VideoMemory { get; set; }
        public int CudaCores { get; set; }
        public GraphicsCard(int fanCount, double speed, int videoMemory, int cudaCores)
        {
            // Determines if all inputs are realistic
            if (fanCount > 0 && speed > 0 && videoMemory > 0 && cudaCores > 0)
            {
                this.FanCount = fanCount;
                this.Speed = speed;
                this.VideoMemory = videoMemory;
                this.CudaCores = cudaCores;
            }
            // If any of the inputs are invalid it will throw an exception with a message based on which input was invalid
            else
            {
                if (fanCount <= 0)
                {
                    throw new Exception(string.Format("Your fan count must be greater than 0"));
                }
                else if (speed <= 0)
                {
                    throw new Exception(string.Format("Your speed must be greater than 0"));
                }
                else if (videoMemory <= 0)
                {
                    throw new Exception(string.Format("Your video memory must be greater than 0"));
                }
                else if (cudaCores <= 0)
                {
                    throw new Exception(string.Format("Your cuda cores must be greater than 0"));
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Represents a Case of a Computer
    /// </summary>
    public class Case
    {
        public Case(int length, int width, int height, int fanAmount, int ventAmount)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.FanAmount = fanAmount;
            this.VentAmount = ventAmount;
        }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int FanAmount { get; set; }
        public int VentAmount { get; set; }
    }
}

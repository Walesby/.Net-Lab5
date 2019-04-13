using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    /// <summary>
    /// Represents who will recieve the mail
    /// </summary>
    public class Receiver
    {
        public string Name { get; set; }
        public string Address { get; set; }
        /// <summary>
        /// Creates a new Receiver
        /// </summary>
        /// <param name="name">Name of the Receiver</param>
        /// <param name="address">Address of the Receiver</param>
        public Receiver(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
    }
}

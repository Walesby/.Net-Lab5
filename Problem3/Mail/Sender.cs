using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    /// <summary>
    /// Represents who sent the mail
    /// </summary>
    public class Sender
    {
        public string Name { get; set; }
        public string Address { get; set; }
        /// <summary>
        /// Creates a new sender
        /// </summary>
        /// <param name="name">Senders name</param>
        /// <param name="address">Where the sender lives</param>
        public Sender(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
    }
}

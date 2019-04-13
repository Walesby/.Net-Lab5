using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    /// <summary>
    /// Represents a piece of mail that the workers will be responsible for sorting
    /// </summary>
    public class Mail
    {
        public Sender Sender { get; set; }
        public Receiver Receiver { get; set; }
        public double PostalCost { get; set; }
        public int Weight { get; set; }
        public bool Flagged { get; set; }
        public string Type { get; set; }
        /// <summary>
        /// Creates a new piece of mail
        /// </summary>
        /// <param name="sender">Who sent the mail</param>
        /// <param name="receiver">Who will recieve the mail</param>
        /// <param name="postalCost">How much it cost to send the mail</param>
        /// <param name="weight">How much the mail weights</param>
        /// <param name="flagged">If the mail is flagged as having something wrong</param>
        /// <param name="type">What type of mail it is "Package", "Letter"</param>
        public Mail(Sender sender, Receiver receiver, double postalCost, int weight, bool flagged, string type)
        {
            this.Sender = sender;
            this.Receiver = receiver;
            this.PostalCost = postalCost;
            this.Weight = weight;
            this.Flagged = flagged;
            this.Type = type;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
    /// <summary>
    /// Represents an item up for auction
    /// </summary>
    public class AuctionItem
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int YearOfCreation { get; set; }
        /// <summary>
        /// Creates a new Auction Item with a random cost as a double
        /// </summary>
        /// <param name="itemName">Name of the item up for auction</param>
        /// <param name="yearOfCreation">Year the item was created</param>
        public AuctionItem(string itemName, int yearOfCreation)
        {
            Random random = new Random();
            this.ItemName = itemName;
            this.ItemPrice = random.NextDouble() * 20;
            this.YearOfCreation = yearOfCreation;
        }
    }
}

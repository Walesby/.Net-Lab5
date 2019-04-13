using Problem4.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
    /// <summary>
    /// Represents a bidder (Observer)
    /// </summary>
    public class AuctionBidder : IAuctionBidder
    {
        private static int AuctionBidderNumber = 0;
        public int BidderId { get; set; }
        public double MaxBid { get; set; }
        private IAuctioneer auctioneer;
        Random random = new Random();

        /// <summary>
        /// Represents an AuctionBidder (Observer)
        /// </summary>
        /// <param name="auctioneer">Which auctioneer they will be able to bid, subscribe and unsubscribe from</param>
        public AuctionBidder(IAuctioneer auctioneer)
        {
            this.auctioneer = auctioneer;
            this.BidderId = AuctionBidderNumber + 1;
            this.MaxBid = random.NextDouble() * 100;
            this.auctioneer.AddObserver(this);
        }

        /// <summary>
        /// Notifies the bidder what the current price of the item is when it gets updated
        /// </summary>
        /// <param name="currentPrice"></param>
        public void NotifyCurrentPrice(double currentPrice)
        {
            Console.WriteLine($"The current bid is: {currentPrice}");
        }

        /// <summary>
        /// Allows the bidder to place a bid on the item up for auction
        /// </summary>
        public void Bid()
        {
            double bid = random.NextDouble() * (MaxBid - 0) + 0;
            this.auctioneer.BidOnItem(bid,this);
        }

        /// <summary>
        /// Allows the bidder to subscribe to the auction
        /// </summary>
        public void Subscribe()
        {
            this.auctioneer.AddObserver(this);
        }

        /// <summary>
        /// Allows the bidder to unsubscribe from the auction
        /// </summary>
        public void Unsubscribe()
        {
            this.auctioneer.RemoveObserver(this);
        }        
    }
}

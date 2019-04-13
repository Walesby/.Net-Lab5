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
        public AuctionBidder(IAuctioneer auctioneer)
        {
            this.auctioneer = auctioneer;
            this.BidderId = AuctionBidderNumber + 1;
            this.MaxBid = random.NextDouble() * 100;
            this.auctioneer.AddObserver(this);
        }
        public void NotifyCurrentPrice(double currentPrice)
        {
            Console.WriteLine($"The current bid is: {currentPrice}");
        }
        public void Bid()
        {
            double bid = random.NextDouble() * (MaxBid - 0) + 0;
            this.auctioneer.BidOnItem(bid,this);
        }
        public void Subscribe()
        {
            this.auctioneer.AddObserver(this);
        }
        public void Unsubscribe()
        {
            this.auctioneer.RemoveObserver(this);
        }        
    }
}

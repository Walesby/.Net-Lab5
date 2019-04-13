using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4.Interface
{
    /// <summary>
    /// Interface that all Auctioneers will implement
    /// </summary>
    public interface IAuctioneer
    {
        void AddObserver(AuctionBidder observer);
        void RemoveObserver(AuctionBidder observer);
        void NotifyAllObservers();
        void BidOnItem(double amount, AuctionBidder observer);
    }
}

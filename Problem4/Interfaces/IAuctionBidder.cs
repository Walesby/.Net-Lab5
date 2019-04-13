using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4.Interface
{
    /// <summary>
    /// Interface that all AuctionBidder will implement
    /// </summary>
    public interface IAuctionBidder
    {
        void Subscribe();
        void Unsubscribe();
        void Bid();
        void NotifyCurrentPrice(double currentBid);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4.Interface
{
    public interface IAuctionBidder
    {
        void Subscribe();
        void Unsubscribe();
        void Bid();
        void NotifyCurrentPrice(double currentBid);
    }
}

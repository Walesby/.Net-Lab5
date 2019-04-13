using Problem4.Interface;
using System;
using System.Collections.Generic;

namespace Problem4
{
    /// <summary>
    /// Represents an Auctioneer
    /// </summary>
    public class Auctioneer : IAuctioneer
    {
        public List<AuctionBidder> observers;
        private AuctionItem auctionItem;
        private int maxBids = 5;
        /// <summary>
        /// Creates a new auctioneer with the provided items and creates a list of AuctionBidder's(Observers)
        /// </summary>
        /// <param name="auctionItem"></param>
        public Auctioneer(AuctionItem auctionItem)
        {
            this.auctionItem = auctionItem;
            this.observers = new List<AuctionBidder>();
        }

        /// <summary>
        /// Allows an observer to add themselves to the notication list for the auction
        /// </summary>
        /// <param name="newObserver">The observer to add to the list</param>
        public void AddObserver(AuctionBidder newObserver)
        {
            if (!observers.Contains(newObserver))
            {
                this.observers.Add(newObserver);
            }
        }

        /// <summary>
        /// Sends a notification to every observer on the observer list of the current price of the item when called
        /// </summary>
        public void NotifyAllObservers()
        {
            double currentBid = auctionItem.ItemPrice;
            foreach (var observer in observers)
            {
                observer.NotifyCurrentPrice(currentBid);
            }
        }

        /// <summary>
        /// Allows an observer to remove themselves from recieving notifications about the auction
        /// </summary>
        /// <param name="removeObserver">The observer to remove from the observer list</param>
        public void RemoveObserver(AuctionBidder removeObserver)
        {
            if (observers.Contains(removeObserver))
            {
                this.observers.Remove(removeObserver);
            }
        }

        /// <summary>
        /// This method is responsible for allowing an AuctionBidder(Observer) to place a bid on the current item
        /// If the bid amount is greater than the current item price it will set the items price to the current bid
        /// Remove one from the max bids and notify all observers of the price change and if it was the final bid
        /// It will remove the observer that bid on the item
        /// </summary>
        /// <param name="bidAmount">How much the observer is bidding on the item</param>
        /// <param name="removeObserver">Used to remove the observer from the subscription list so they wont recieve notifications if they win the bid</param>
        public void BidOnItem(double bidAmount, AuctionBidder removeObserver)
        {
            if (bidAmount > auctionItem.ItemPrice && maxBids != 0)
            {
                auctionItem.ItemPrice = bidAmount;
                maxBids = maxBids - 1;
                NotifyAllObservers();
                if (maxBids == 0)
                {
                    this.observers.Remove(removeObserver);
                }
            }            
        }
    }
}

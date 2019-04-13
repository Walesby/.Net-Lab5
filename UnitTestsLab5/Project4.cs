using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem4;
namespace UnitTestsLab5
{
    [TestClass]
    public class Project4
    {
        [TestMethod]
        public void TestSubscribeToAuctionMethodPass()
        {
            AuctionItem auctionItem = new AuctionItem("Gorilla statue", 1400);
            Auctioneer auctioneer = new Auctioneer(auctionItem);
            AuctionBidder auctionBidder = new AuctionBidder(auctioneer);
            auctionBidder.Subscribe();

            bool expected = true;
            bool result = auctioneer.observers.Contains(auctionBidder);

            Assert.AreEqual(expected,result);
        }
        [TestMethod]
        public void TestUnsubscribeToAuctionMethodPass()
        {
            AuctionItem auctionItem = new AuctionItem("Gorilla statue", 1400);
            Auctioneer auctioneer = new Auctioneer(auctionItem);
            AuctionBidder auctionBidder = new AuctionBidder(auctioneer);
            auctionBidder.Subscribe();
            auctionBidder.Unsubscribe();

            bool expected = false;
            bool result = auctioneer.observers.Contains(auctionBidder);

            Assert.AreEqual(expected, result);
        }
    }
}

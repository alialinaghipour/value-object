namespace ValueObjects
{
    public class Auction
    {
        public AuctionPrice Price { get;private set; }

        public void Raise()
        {
            Price = Price.Raise();
        }

        public void Proposal(decimal value)
        {
            Price=Price.Proposal(value);
        }
    }
}
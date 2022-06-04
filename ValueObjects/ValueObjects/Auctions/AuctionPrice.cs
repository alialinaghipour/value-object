namespace ValueObjects
{
    public class AuctionPrice : BaseValueObject<AuctionPrice>
    {
        private readonly decimal _price;

        public AuctionPrice(decimal value)
        {
            if (value < 10)
            {
                throw new Exception();
            }
            _price = value;
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
        }

        public AuctionPrice Raise()
        {
            decimal aditionalValue = 0;
            if (Price > 10 && Price < 100)
            {
                aditionalValue = 20;
            }
            else if (Price > 100 && Price < 400)
            {
                aditionalValue = 50;
            }
            else if (Price > 400 && Price < 1000)
            {
                aditionalValue = 150;
            }
            else
            {
                aditionalValue = 400;
            }
            return new AuctionPrice(Price + aditionalValue);
        }

        public AuctionPrice Proposal(decimal aditionalValue)
        {
            if ((Price > 10 && Price < 100 && aditionalValue >= 10) ||
                (Price > 100 && Price < 400 && aditionalValue >= 50) ||
                (Price > 400 && Price < 1000 && aditionalValue >= 150) ||
                (aditionalValue >= 400))
            {
                return new AuctionPrice(Price + aditionalValue);
            }
            throw new Exception();
        }

        protected override bool EqualsCore(AuctionPrice other)
        {
            return Price == other.Price;
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}
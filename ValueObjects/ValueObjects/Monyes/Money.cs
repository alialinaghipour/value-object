namespace ValueObjects.Monyes
{
    public class Money : BaseValueObject<Money>
    {
        private readonly int _value;
        public int Value 
        { 
            get 
            {
                return _value;
            } 
        }

        public Money(int value)
        {
            _value = value;
        }

        public Money Add(Money input)
        {
            return new Money(_value + input.Value);
        }

        public Money Subtract(Money input)
        {
            return new Money(_value - input.Value);
        }

        protected override bool EqualsCore(Money other)
        {
            throw new NotImplementedException();
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }

        public static Money operator +(Money left,Money right)
        {
            return left.Add(right);
        }

        public static Money operator -(Money left, Money right)
        {
            return left.Subtract(right);
        }
    }
}

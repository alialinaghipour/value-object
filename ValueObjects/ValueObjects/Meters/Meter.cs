namespace ValueObjects.Meters
{
    public class Meter
    {
        private readonly int _value;
        public Meter(int value)
        {
            _value = value;
        }

        public KilooMeter ToKilooMeter()
        {
            var kilooMeter = _value / 1000;
            return new KilooMeter(kilooMeter);
        }

        public Inche ToInche()
        {
            return new Inche(_value / 2);
        }
    }
}

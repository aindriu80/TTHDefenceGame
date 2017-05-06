namespace TeamTreeHouse
{
    public class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;

        private static readonly System.Random _random = new System.Random();

        private readonly MapLocation _location;
        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }
        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    invader.DecreaseHealth(_power);
                    break;
                }
            }
        }

        public static double CalculateHypotenuse(double side1, double side2)
        {
            return System.Math.Sqrt(System.Math.Pow(side1, 2) + System.Math.Pow(side2, 2));

        }
    }
}

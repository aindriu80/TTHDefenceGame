namespace TeamTreeHouse
{
    public class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            //if (!map.OnMap(this))
            //{
            //    throw new OutOfBoundsException();
            //}
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) < -range;
        }
    }
}

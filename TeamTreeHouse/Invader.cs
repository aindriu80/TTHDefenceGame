using System;

namespace TeamTreeHouse
{
    public abstract class Invader : IInvader
    {
        public virtual string Description => "";
        private readonly Path _path;
        private int _pathStep = 0;

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public int Health { get; set; } = 2;

        //True if the invader has reached the end of the path
        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNuetralized => Health <= 0;

        public bool IsActive => !(IsNuetralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += 1;

        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }
    }




}

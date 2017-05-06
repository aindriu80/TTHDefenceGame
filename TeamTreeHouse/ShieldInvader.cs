using System;
namespace TeamTreeHouse
{
    public abstract class ShieldInvader : Invader
    {
        private static System.Random _random = new System.Random();
        public virtual int Health { get; protected set; } = 2;
        public ShieldInvader(Path path) : base(path)
        {

        }

        public virtual void DecreaseHealth(int factor)
        {
            if (_random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            }

            else
            {
                Console.WriteLine("Shot at a shield invader but it sustained no damage");
            }
        }
    }


}

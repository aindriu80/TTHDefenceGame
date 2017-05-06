namespace TeamTreeHouse
{
   public interface IIMappable
    {
        MapLocation Location { get; }
    }

    public interface IMovable
    {
        void Move();
    }
    public interface IInvader : IIMappable, IMovable
    {
      

        bool HasScored { get; }
        int Health { get; }

        bool IsNuetralized { get; }

        bool IsActive { get; }

       

        void DecreaseHealth(int factor);
       

    }
}

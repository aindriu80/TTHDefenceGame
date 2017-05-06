namespace TeamTreeHouse
{
    public class StrongInvader : Invader
    {
        public virtual int Health { get; protected set; } = 2;

        public StrongInvader(Path path) : base(path)
        {
        }
    }
}

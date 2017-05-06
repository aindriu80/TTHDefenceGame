namespace TeamTreeHouse
{
    public class BasicInvader : Invader
    {
        public virtual int Health { get; protected set; } = 2;
        public BasicInvader(Path path) : base(path)
        {
        }
    }
}

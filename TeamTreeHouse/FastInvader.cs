namespace TeamTreeHouse
{
    abstract class FastInvader : Invader
    {
        public override string Description => "Detects repetitions";

        public virtual int Health { get; protected set; } = 2;

        protected virtual int StepSize { get; } = 1;



        public FastInvader(Path path) : base(path)
        {
        }
    }
}
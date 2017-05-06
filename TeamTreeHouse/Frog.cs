namespace Treehouse.CodeChallenges
{
    class Frog
    {
        public readonly int TongueLength;
        public readonly int ReactionTime;


        public Frog(int tongueLength, int reactionTime)
        {
            TongueLength = tongueLength;
            ReactionTime = reactionTime;
        }

        public bool EatFly(int distanceToFly)
        {
            return TongueLength >= distanceToFly;
        }

        public bool EatFly(int distanceToFly, int flyReactionTime)
        {
            return TongueLength >= distanceToFly & ReactionTime >= flyReactionTime;


        }

        public static double GetAverageTongueLength(Frog[] frogs)
        {
            double frogsTongueLength = 0.0;

            for (int i = 0; i < frogs.Length; i++)
            {
                frogsTongueLength += frogs[i].TongueLength;
            }
            return frogsTongueLength / frogs.Length;
        }

        public static double GetAverageTongueLength2(Frog[] frogs)
        {
            var frogsTongue = 0;
            var average = 0;
            var count = 0;
            foreach (var frog in frogs)
            {
                frogsTongue += frog.TongueLength;
                count++;
            }

            average = (frogsTongue / count);
            return average;

        }

    }
}
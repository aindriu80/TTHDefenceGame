using System;
namespace TeamTreeHouse
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);
            try
            {
                Path path = new Path(
                    new[]
                    {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    }

                );

                Invader[] invaders =
                {
                    new BasicInvader(path),
                    new BasicInvader(path),
                    new StrongInvader(path),
                    new BasicInvader(path)
                };

                Tower[] towers =
                {
                    new Tower(new MapLocation(1, 3, map)),
                    new Tower(new MapLocation(3, 3, map)),
                    new Tower(new MapLocation(5, 3, map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };
                bool playersWon = level.Play();

                Console.WriteLine("Player " + (playersWon ? "won" : "lost"));

            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //    Map map = new Map(8, 5);

            //    //Point point = new Point(4, 2);

            //    MapLocation x = new MapLocation(4, 2);

            //    //Console.WriteLine(point.DistanceTo(5, 5));
            //    Console.WriteLine(x.DistanceTo(5, 5));
            //}
        }
    }
}

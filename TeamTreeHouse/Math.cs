namespace TeamTreeHouse
{
    public class MathHelpers
    {
        public int _numFliesEaten;

        public int GetNumFliesEaten()
        {
            return _numFliesEaten;
        }

        public void SetNumFliesEaten(int x)
        {
            _numFliesEaten = x;
        }

        public int NumFliesEaten { get; set; }




        public static int[][] BuildMultiplicationTable(int maxFactor)
        {
            int[][] arr = new int[maxFactor + 1][];

            for (int x = 0; x <= maxFactor; x++)
            {
                arr[x] = new int[maxFactor + 1];

                for (int y = 0; y <= maxFactor; y++)
                {
                    arr[x][y] = x * y;
                }
            }

            return arr;
        }

        public static int[,] BuildMultiplicationTable2(int maxFactor)
        {
            int[,] arr = new int[maxFactor + 1, maxFactor + 1];
            for (int i = 0; i < maxFactor; i++)
            {
                for (int j = 0; j < maxFactor; j++)
                {
                    arr[i, j] = i * j;
                }
            }

            return arr;
        }
    }
}

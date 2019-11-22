namespace P03_JediGalaxy
{
    public class Universe
    {
        private int[,] universe;

        public Universe(int firstDimension, int secondDimension)
        {
            this.universe = new int[firstDimension, secondDimension];
        }

        public void Fill()
        {
            int value = 0;
            for (int i = 0; i < this.universe.GetLength(0); i++)
            {
                for (int j = 0; j < this.universe.GetLength(1); j++)
                {
                    this.universe[i, j] = value++;
                }
            }
        }

        public long CollectStars(Point point)
        {
            long sum = 0;
            while (point.CoordinateX >= 0 && point.CoordinateY < this.universe.GetLength(1))
            {
                if (point.CoordinateX < this.universe.GetLength(0) && point.CoordinateY >= 0)
                {
                    sum += this.universe[point.CoordinateX, point.CoordinateY];
                }

                point.CoordinateY++;
                point.CoordinateX--;
            }

            return sum;
        }

        public  void MoveEvil(Point point)
        {
            while (point.CoordinateX >= 0 && point.CoordinateY >= 0)
            {
                if (point.CoordinateX < this.universe.GetLength(0) && point.CoordinateY < this.universe.GetLength(1))
                {
                    this.universe[point.CoordinateX, point.CoordinateY] = 0;
                }

                point.CoordinateX--;
                point.CoordinateY--;
            }
        }
    }
}

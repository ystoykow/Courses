namespace P03_JediGalaxy
{
    using System;
    using System.Linq;

   public class Program
    {
        public static void Main()
        {
            int[] dimestions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int x = dimestions[0];
            int y = dimestions[1];
            Universe universe = new Universe(x,y);
            universe.Fill();

            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] ivoCoordinates = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] evilCoordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                Point evilPosition = new Point
                {
                    CoordinateX = evilCoordinates[0],
                    CoordinateY = evilCoordinates[1]
                };

                universe.MoveEvil(evilPosition);
                Point ivoPosition = new Point
                {
                    CoordinateX = ivoCoordinates[0],
                    CoordinateY = ivoCoordinates[1]
                };

                sum += universe.CollectStars(ivoPosition);
                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}

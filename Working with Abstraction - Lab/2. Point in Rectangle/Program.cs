using System.Linq;

namespace _2.PointInRectangle
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] rectanglePoints = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Point topLeft = new Point();
            Point bottomRight= new Point();
            topLeft.CoordinateX = rectanglePoints[0];
            topLeft.CoordinateY = rectanglePoints[1];
            bottomRight.CoordinateX = rectanglePoints[2];
            bottomRight.CoordinateY = rectanglePoints[3];
            Rectangle rectangle = new Rectangle();
            rectangle.TopLeft = topLeft;
            rectangle.BottomRight = bottomRight;
            int pointsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < pointsCount; i++)
            {
                Point currentPoint = new Point();
                int[] currentPointCoords = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                currentPoint.CoordinateX = currentPointCoords[0];
                currentPoint.CoordinateY = currentPointCoords[1];
                Console.WriteLine(rectangle.Contains(currentPoint));
            }
        }
    }
}

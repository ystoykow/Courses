namespace _2.PointInRectangle
{
    public class Rectangle
    {
        public Point TopLeft { get; set; }

        public Point BottomRight { get; set; }

        public bool Contains(Point point)
        {
            bool result = false;
            if (point.CoordinateX >= this.TopLeft.CoordinateX &&
                point.CoordinateX <= this.BottomRight.CoordinateX &&
                point.CoordinateY >= this.TopLeft.CoordinateY &&
                point.CoordinateY <= this.BottomRight.CoordinateY)
            {
                result = true;
            }

            return result;
        }
    }
}

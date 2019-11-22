namespace Shapes
{
    public class Rectangle:Shape
    {
        private double height;
        private double width;

        public Rectangle(double height,double width)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculatePerimeter()
        {
            return this.height * 2 + this.width * 2;
        }

        public override double CalculateArea()
        {
            return this.height * this.width;
        }

        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}

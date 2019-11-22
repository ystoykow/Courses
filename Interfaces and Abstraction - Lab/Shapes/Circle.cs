namespace Shapes
{
    using System;

    public class Circle : IDrawable
    {
        private int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int Radius
        {
            get => this.radius;
            private set
            {
                if (value <= 0)
                {
                    this.radius = 0;
                }
                else
                {
                    this.radius = value;
                }
            }
        }

        public void Draw()
        {
            double innerRadius = this.Radius - 0.4;
            double outerRadius = this.Radius + 0.4;
            for (double i = this.Radius; i >= -this.Radius; --i)
            {
                for (double j = -this.Radius; j < outerRadius; j += 0.5)
                {
                    double value = i * i + j * j;
                    if (value >= innerRadius * innerRadius && value <= outerRadius * outerRadius)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }

                Console.WriteLine();
            }
        }
    }
}

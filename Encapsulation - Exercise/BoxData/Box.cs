using System;

namespace BoxData
{
    using System.Text;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }

            this.length = length;
            if (width <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }

            this.width = width;
            if (height <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }

            this.height = height;
        }

        public double SurfaceArea()
        {
            return 2 * this.length * this.width +
                   2 * this.length * this.height +
                   2 * this.width * this.height;
        }

        public double LateralSurfaceArea()
        {
            return 2 * this.length * this.height + 2 * this.width * this.height;
        }

        public double Volume()
        {
            return this.length * this.width * this.height;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {this.SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {this.Volume():f2}");
            return sb.ToString().Trim();
        }
    }
}

namespace Shapes
{
    using System;

    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Width
        {
            get => this.width;
            private set
            {
                if (value <= 0)
                {
                    this.width = 0;
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public int Height { get=>this.height;
            private set
            {
                if (value <= 0)
                {
                    this.height = 0;
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public void Draw()
        {
            DrawLine(this.Width, '*', '*');
            for (int i = 1; i < this.Height - 1; ++i)
            {
                DrawLine(this.Width, '*', ' ');
            }

            DrawLine(this.Width, '*', '*');
        }

        private void DrawLine(in int width, char borderChar, char fillChar)
        {
            Console.Write(borderChar);
            for (int i = 1; i < width - 1; ++i)
            {
                Console.Write(fillChar);
            }

            Console.WriteLine(borderChar);
        }
    }
}

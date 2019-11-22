namespace P02.Graphic_Editor
{
    public class SquareGraphicEditor:GraphicEditor
    {
        protected override void DrawShape(IShape shape)
        {
            var square = shape as Square;
            //draw
        }
    }
}

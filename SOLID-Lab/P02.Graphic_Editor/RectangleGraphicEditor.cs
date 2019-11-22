namespace P02.Graphic_Editor
{
    public class RectangleGraphicEditor:GraphicEditor
    {
        protected override void DrawShape(IShape shape)
        {
            var rectangle = shape as Rectangle;
            //draw
        }
    }
}

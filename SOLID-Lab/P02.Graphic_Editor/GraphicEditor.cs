namespace P02.Graphic_Editor
{
    public abstract class GraphicEditor:IGraphicEditor
    {
        public void Draw(IShape shape)
        {
            this.DrawShape(shape);
        }

        protected abstract void DrawShape(IShape shape);
    }
}

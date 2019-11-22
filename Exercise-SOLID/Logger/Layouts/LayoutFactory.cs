namespace Logger.Layouts
{
    using Contracts;
    using System;

    public class LayoutFactory : ILayoutFactory
    {
        public ILayout Create(string type)
        {
            string typeAsLower = type.ToLower();
            switch (typeAsLower)
            {
                case"xmllayout":
                    return new XmlLayout();
                case"simplelayout":
                    return new SimpleLayout();
                default:
                    throw new ArgumentException("Invalid layout type!");
            }
        }
    }
}

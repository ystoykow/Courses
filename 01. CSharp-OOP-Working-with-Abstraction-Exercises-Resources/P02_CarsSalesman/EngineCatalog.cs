namespace P02_CarsSalesman
{
    using System.Collections.Generic;
    public class EngineCatalog
    {
        private List<Engine> engines;

        public EngineCatalog()
        {
            this.engines = new List<Engine>();
        }

        public List<Engine> Engines { get; private set; }

        public void Add(Engine engine)
        {
            this.engines.Add(engine);
        }
    }
}

namespace P03_StudentSystem
{
    public class StartUp
    {
        public static void Main()
        {
            DataWriter dataWriter = new DataWriter();
            DataReader dataReader = new DataReader();
            Engine engine = new Engine();
            engine.Run(dataWriter,dataReader);
        }
    }
}

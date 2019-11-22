namespace Logger
{
    using Core;
    
    public class Program
    {
        public static void Main()
        {
            CommandInterpreter commandInterpreter = new CommandInterpreter();
            Engine engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}

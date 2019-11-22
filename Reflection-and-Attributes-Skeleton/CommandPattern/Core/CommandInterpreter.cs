namespace CommandPattern.Core
{
    using Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string CommandPostfix = "Command";

        public string Read(string args)
        {
            string[] tokens = args
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string commandName = tokens[0] + CommandPostfix;
            string[] commandArgs = tokens
                .Skip(1)
                .ToArray();
            var command = (ICommand)Activator
                .CreateInstance(Assembly
                    .GetCallingAssembly()
                    .GetTypes()
                    .FirstOrDefault(t => t.Name == commandName));
            return command.Execute(commandArgs);
        }
    }
}

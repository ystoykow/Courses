﻿namespace Logger.Core
{
    using Contracts;
    using System;

    public class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {

            int appendersCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < appendersCount; i++)
            {
                string[] args = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                this.commandInterpreter.AddAppender(args);
            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] args = input
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                this.commandInterpreter.AddReport(args);
                input = Console.ReadLine();
            }

            this.commandInterpreter.PrintInfo();
        }
    }
}

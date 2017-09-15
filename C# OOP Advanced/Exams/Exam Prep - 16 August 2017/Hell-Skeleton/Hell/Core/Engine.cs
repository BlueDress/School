using Hell.Interfaces.Core;
using Hell.Interfaces.Entities;
using Hell.Interfaces.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class Engine : IEngine
{
    private IInputReader reader;
    private IOutputWriter writer;
    private IManager heroManager;

    public Engine(IInputReader reader, IOutputWriter writer, IManager heroManager)
    {
        this.reader = reader;
        this.writer = writer;
        this.heroManager = heroManager;
    }

    public void Run()
    {
        bool isRunning = true;

        while (isRunning)
        {
            string inputLine = this.reader.ReadLine();
            IList<string> arguments = this.parseInput(inputLine);
            this.writer.WriteLine(this.processInput(arguments));
            isRunning = !this.ShouldEnd(inputLine);
        }
    }

    private IList<string> parseInput(string input)
    {
        return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
    }

    private string processInput(IList<string> arguments)
    {
        string command = arguments[0];
        arguments.RemoveAt(0);

        var commandType = Assembly.GetExecutingAssembly().GetTypes().First(t => t.Name.Equals(command + "Command"));
        var constructor = commandType.GetConstructors();//(new Type[] { typeof(IList<string>), typeof(IManager) });
        ICommand cmd = (ICommand)constructor[0].Invoke(new object[] { arguments, this.heroManager });
        return cmd.Execute();
    }

    private bool ShouldEnd(string inputLine)
    {
        return inputLine.Equals("Quit");
    }
}
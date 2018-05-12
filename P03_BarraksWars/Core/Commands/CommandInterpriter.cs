
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


public class CommandInterpreter : ICommandInterpreter
{
    private IServiceProvider serviceProvider;

    public CommandInterpreter(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    public IExecutable InterpretCommand(string[] data, string commandName)
    {

        Assembly assembly = Assembly.GetCallingAssembly();

        var commandType = assembly
            .GetTypes()
            .FirstOrDefault(t => t.Name.ToLower() == commandName + "command");

        if (commandType == null)
        {
            throw new ArgumentException("Invalid command");
        }

        if (!typeof(IExecutable).IsAssignableFrom(commandType))
        {
            throw new Exception($"{commandName } is not valid command!");
        }

        FieldInfo[] fieldsToInject = commandType
            .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
            .Where(f => f.CustomAttributes.Any(ca => ca.AttributeType == typeof(InjectAttribute)))
            .ToArray();

        object[] injectArgs = fieldsToInject.Select(f => this.serviceProvider.GetService(f.FieldType)).ToArray();

        object[] commandArgs = new object[] { data }.Concat(injectArgs).ToArray();

        IExecutable instance = (IExecutable)Activator.CreateInstance(commandType, commandArgs);

        return instance;
    }
}


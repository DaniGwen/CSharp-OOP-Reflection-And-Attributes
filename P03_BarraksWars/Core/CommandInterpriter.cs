using _03BarracksFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace P03_BarraksWars.Contracts.Core
{
   public class CommandInterpriter : ICommandInterpreter
    {
		private IRepository repository;
		private IUnitFactory unitFactory;

		private IExecutable InterpredCommand(string[] data, string commandName)
		{

			Assembly assembly = Assembly.GetCallingAssembly();

			Type commandType = assembly
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

			MethodInfo method = typeof(IExecutable).GetMethods().First();

			object[] commandArgs = new object[] { data, this.repository, this.unitFactory };
			object instance = Activator.CreateInstance(commandType, commandArgs);

			try
			{
				string result = (string)method.Invoke(instance, null);
				return result;
			}
			catch (TargetInvocationException e)
			{
				throw e.InnerException;
			}

		}
	}
}

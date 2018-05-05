namespace _03BarracksFactory.Core.Factories
{
	using System;
	using System.Linq;
	using System.Reflection;
	using Contracts;

	public class UnitFactory : IUnitFactory
	{
		public IUnit CreateUnit(string unitType)
		{
			Assembly assembly = Assembly.GetExecutingAssembly();
			Type model = assembly.GetTypes().FirstOrDefault(t => t.Name == unitType);
			if (unitType == null)
			{
				throw new ArgumentException("Unit is empty");
			}

			if (!typeof(IUnit).IsAssignableFrom(model))
			{ 
				throw new ArgumentException($"{unitType} is not a unit type!");
			}

			IUnit unit = (IUnit)Activator.CreateInstance(model);

			return unit;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;
using System.Reflection;


public class Tracker
{
	public void PrintMethodsByAuthor()
	{
		var type = typeof(StartUp);

		var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

		foreach (var method in methods)
		{
			if (method.CustomAttributes.Any(a => a.AttributeType == typeof(SoftUniAttribute)))
			{
				var attrs = method.GetCustomAttributes(false);
				foreach (SoftUniAttribute attr in attrs)
				{
					Console.WriteLine($"{method.Name} is writen by {attr.Name}");
				}
			}
		}
	}
}



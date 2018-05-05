using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _6.CodingTracker
{
	public class Tracker
	{
		static void printMethodsByAuthor()
		{
			var type = typeof(StartUp);

			var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

			foreach (var method in methods)
			{
				if (method.CustomAttributes.Any(n => n.AttributeType.CustomAttributes))
				{

				}
			}
		}
	}
}

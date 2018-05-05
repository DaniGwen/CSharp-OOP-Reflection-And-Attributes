namespace P02_BlackBoxInteger
{
	using System;
	using System.Linq;
	using System.Reflection;

	public class BlackBoxIntegerTests
	{
		public static void Main()
		{
			Type type = Type.GetType("P02_BlackBoxInteger.BlackBoxInteger");

			var instance = Activator.CreateInstance(type, true);

			FieldInfo innerValue = type.GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic);

			MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

			string input;
			while ((input = Console.ReadLine()) != "END")
			{
				string[] tokens = input.Split('_');
				string command = tokens[0];
				int number = int.Parse(tokens[1]);

				//two ways of getting the method by command. Current used is //method//
				MethodInfo method = type.GetMethod(command, BindingFlags.Instance | BindingFlags.NonPublic);
				MethodInfo method1 = methods.First(m => m.Name == " command")

;				method.Invoke(instance, new object[] { number });

				Console.WriteLine(innerValue.GetValue(instance));
			}

		}
	}
}

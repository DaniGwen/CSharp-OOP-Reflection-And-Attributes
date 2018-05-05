using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


public class Spy
{
	public string StealFieldInfo(string className, params string[] fieldsToInvestigate)
	{
		Type classType = Type.GetType(className);

		FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance
			| BindingFlags.Static
			| BindingFlags.NonPublic
			| BindingFlags.Public);

		StringBuilder stringBuilder = new StringBuilder();

		Object classInstance = Activator.CreateInstance(classType, new object[] { });

		stringBuilder.AppendLine($"Class under investigation: {className}");

		foreach (FieldInfo  field in classFields.Where(f => fieldsToInvestigate.Contains(f.Name)))
		{
			stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
		}

		return stringBuilder.ToString().TrimEnd();
	}
}


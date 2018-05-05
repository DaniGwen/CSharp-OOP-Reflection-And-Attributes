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

		foreach (FieldInfo field in classFields.Where(f => fieldsToInvestigate.Contains(f.Name)))
		{
			stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
		}

		return stringBuilder.ToString().TrimEnd();
	}

	public string AnalyzeAcessModifiers(string className)
	{
		Type classType = Type.GetType(className);
		FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance
			| BindingFlags.Public
			| BindingFlags.Static);


		var properties = classType.GetProperties(BindingFlags.Instance
			| BindingFlags.Public
			| BindingFlags.NonPublic);

		StringBuilder stringBuilder = new StringBuilder();

		foreach (FieldInfo field in classFields)
		{
			stringBuilder.AppendLine($"{field.Name} must be private!");
		}

		foreach (PropertyInfo method in properties)
		{
			if (method.GetMethod?.IsPrivate == true)
				stringBuilder.AppendLine($"{method.GetMethod.Name} have to be public!");
		}

		foreach (PropertyInfo method in properties)
		{
			if (method.SetMethod?.IsPublic == true)
				stringBuilder.AppendLine($"{method.GetMethod.Name} have to be private");
		}
		return stringBuilder.ToString().TrimEnd();
	}
}


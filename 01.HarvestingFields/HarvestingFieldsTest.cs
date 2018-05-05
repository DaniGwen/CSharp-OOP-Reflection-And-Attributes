
using System;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Collections.Generic;

public class HarvestingFieldsTest
{
    public static void Main()
    {
        Type typeOfClass = typeof(HarvestingFields);
        FieldInfo[] fieldsInfo = typeOfClass.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

        string command;

        while ((command = Console.ReadLine()) != "HARVEST")
        {
            switch (command)
            {
                case "private":
					Console.WriteLine(AppendFields(fieldsInfo.Where(f => f.IsPrivate)));
                    break;
                case "protected":
					Console.WriteLine(AppendFields(fieldsInfo.Where(f => f.IsFamily)));
                    break;
                case "public":
					Console.WriteLine(AppendFields(fieldsInfo.Where(f => f.IsPublic)));
                    break;
                case "all":
					Console.WriteLine(AppendFields(fieldsInfo)); 
                    break;
                default:
                    throw new Exception("unknown command");
            }

        }

    }

    public static string AppendFields(IEnumerable<FieldInfo> fieldsInfo)
    {
        var sb = new StringBuilder();

        foreach (var field in fieldsInfo)
        {
            var accessModifier = field.Attributes.ToString().ToLower();

            if (accessModifier.Equals("family"))
            {
                accessModifier = "protected";
            }

            sb.AppendLine($"{accessModifier} {field.FieldType.Name} {field.Name}");
        }

		return sb.ToString().TrimEnd();
    }
}


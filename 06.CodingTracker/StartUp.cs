using System;
using System.Reflection;

[SoftUni("Ventsi")]
public class StartUp
{
	[SoftUni("peshko")]
	static void Main()
	{
		var tracker = new Tracker();
		tracker.PrintMethodsByAuthor();
	}

	[SoftUni("Icko")]
	static void SomeMethod()
	{

	}

	[SoftUni("Denko")]
	static string returnString()
	{
		return "f*** you!!";
	}
}


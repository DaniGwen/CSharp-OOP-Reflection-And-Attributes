using System;
using System.Collections.Generic;
using System.Text;

namespace _05.CreateAttribute
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class SoftUniAttribute : Attribute
    {
		public SoftUniAttribute(string name)
		{
			this.name = name;
		}
		public string name { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace _5.CreateAttribute
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]

    public class SoftUniAttributes: Attribute
    {
		public SoftUniAttributes(string name)
		{
			this.Name = name;
		}

		public string Name { get; private set; }
	}
}

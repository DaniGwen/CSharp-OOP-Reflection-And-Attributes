using System;
using System.Reflection;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(MyTestClass);
			var instance = Activator.CreateInstance(typeof(MyTestClass), new object[] { });
			var field = type.GetProperty("BankNumber");
			field.SetValue(instance, 1020);
			;
			
        }
    }
}

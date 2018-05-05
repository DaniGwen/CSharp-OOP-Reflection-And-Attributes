using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
	class MyTestClass
	{
		public MyTestClass()
		{

		}

		public MyTestClass(int age, string name) : this()
		{
			this.Name = name;
			this.Age = age;
		}
		public MyTestClass(int age, string name, int bankNumber) : this(age, name)
		{
			this.BankNumber = bankNumber;
		}

		private int bankNumber;

		public int BankNumber
		{
			get { return bankNumber; }
			private set { bankNumber = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}


	}
}

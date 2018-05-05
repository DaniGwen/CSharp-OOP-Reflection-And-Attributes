using _03BarracksFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_BarraksWars.Contracts.Core
{
	
	public abstract class Command : IExecutable
	{
		private string[] data;
		private IRepository repository;
		private IUnitFactory unitFactory;

		public Command(string[] data, IRepository repository, IUnitFactory unitFactory)
		{ 
			this.Data = data;
			this.Repository = repository;
			this.UnitFactory = unitFactory;
		}

		protected string[] Data { get; private set; }

		protected IRepository Repository { get; private set; }

		protected IUnitFactory UnitFactory { get; private set; }

		public abstract string Execute()
		{
			throw new System.NotImplementedException();  
		}
	}
}

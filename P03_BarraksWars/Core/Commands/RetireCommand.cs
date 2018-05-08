using System;
using System.Collections.Generic;
using System.Text;
using _03BarracksFactory.Contracts;
using P03_BarraksWars.Core.Commands;

namespace P03_BarraksWars.Contracts.Core.Commands
{
	public class RetireCommand : Command
	{
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data, IRepository repository) : base(data)
		{
           
		}

        protected IRepository Repository
        {
            get { return repository; }
            private set { repository = value; }
        }

        public override string Execute()
		{
			string unitType = Data[1];
			try
			{
				this.Repository.RemoveUnit(unitType);
				return $"{unitType} retired!";
			}
			catch (Exception e)
			{
				throw new ArgumentException("No such units in repository.", e);
			}
		}
	}
}

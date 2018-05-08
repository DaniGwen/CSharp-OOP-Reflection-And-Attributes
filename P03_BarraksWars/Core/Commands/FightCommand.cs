using System;
using System.Collections.Generic;
using System.Text;
using _03BarracksFactory.Contracts;

namespace P03_BarraksWars.Contracts.Core.Commands
{
	public class FightCommand : Command
	{
		public FightCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data)
		{
		}

		public override string Execute()
		{
			Environment.Exit(0);
			return null;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

public class FightCommand : Command
{
    //public FightCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data)
    //{
    //}

    public override string Execute()
    {
        Environment.Exit(0);
        return null;
    }
}


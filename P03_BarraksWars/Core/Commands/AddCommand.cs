
using System;
using System.Collections.Generic;
using System.Text;


public class AddCommand : Command
{
    [Inject]
    private IRepository repository;
    [Inject]
    private IUnitFactory unitFactory;

    public AddCommand(string[] data, IRepository repository, IUnitFactory unitFactory)
        : base(data)
    {
        this.unitFactory = unitFactory;
        this.repository = repository;
    }

    protected IRepository Repository
    {
        get { return repository; }
        private set { repository = value; }
    }

    protected IUnitFactory UnitFactory
    {
        get { return unitFactory; }
        private set { unitFactory = value; }
    }

    public override string Execute()
    {
        string unitType = this.Data[1];
        IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);
        this.Repository.AddUnit(unitToAdd);
        string output = unitType + " added!";
        return output;
    }
}


using System;
using System.Collections.Generic;
using System.Text;


public class Engine
{
    //model, power, displacement and efficiency
    private string model;
    private int power;
    private int displacement;
    private string efficiency;
    
    public Engine()
    {

    }
    public Engine(string model , int power): this()
    {
        this._Model = model;
        this._Power = power;
    }

    public Engine(string model, int power, int displacement, string efficiency):this(model,power)
    {
        this._Displacement = displacement;
        this._Efficiency = efficiency;
    }

    public string _Efficiency
    {
        get { return efficiency; }
        set { efficiency = value; }
    }

    public int _Displacement
    {
        get { return displacement; }
        set { displacement = value; }
    }

    public int _Power
    {
        get { return  power; }
        set {  power = value; }
    }

    public string _Model
    {
        get { return model; }
        set { model = value; }
    }

    public override string ToString()
    {
        return base.ToString(); 
    }
}

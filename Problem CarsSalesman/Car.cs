using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string model;
    private Engine engine;
    private int weight;
    private string colour;

    public Car()
    {

    }

    public Car(string model, Engine engine) : this()
    {
        this._Engine = engine;
        this._Model = model;
    }
    public Car(string model, Engine engine, int wight, string colour) : this(model, engine)
    {
        this._Weight = weight;
        this._Colour = colour;
    }

    public string _Colour
    {
        get { return colour; }
        set { colour = value; }
    }

    public int _Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public Engine _Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    public string _Model
    {
        get { return model; }
        set { model = value; }
    }

}

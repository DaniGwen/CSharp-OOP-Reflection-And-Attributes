using System;
using System.Collections.Generic;
using System.Text;

public class Repository
{
    private List<Engine> engines;
    private List<Car> cars;

    public Repository()
    {
        cars = new List<Car>();
        engines = new List<Engine>();
    }

    public void AddCar(Car car)
    {
        if (!cars.Contains(car))
        {
            cars.Add(car);
        }
    }

    public void AddEngine(Engine engine)
    {
        if (!engines.Contains(engine))
        {
            engines.Add(engine);
        }
    }

    public Engine GetEngine(string engine)
    {
        Engine defaultEngine = new Engine();

        foreach (var item in engines)
        {
            if (item.ToString() == engine)
            {
                defaultEngine = item;
            }
            else
            {
                throw new ArgumentException("No such engine!");
            }
        }
        return defaultEngine;
    }
}


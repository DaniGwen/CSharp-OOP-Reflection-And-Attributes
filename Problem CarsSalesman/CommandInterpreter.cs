using System;
using System.Collections.Generic;
using System.Text;


public class CommandInterpreter
{
    Repository repository;

    public CommandInterpreter()
    {
        this.repository = new Repository();
    }

    public void ReadEngines()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();

            var model = input[0];
            var power = int.Parse(input[1]);
            int displacement = 0;
            string efficiency = " ";

            var engine = new Engine(model, power);

            if (input.Length > 2 && input.Length < 4)
            {
                displacement = int.Parse(input[2]);
                engine._Displacement = displacement;
            }
            if (input.Length > 3)
            {
                efficiency = input[3];
                engine._Efficiency = efficiency;
            }

            repository.AddEngine(engine);
        }
    }

    public void ReadCars()
    {
        int m = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            var input = Console.ReadLine().Split();

            var model = input[0];
            var engine = (input[1]);
            int weight = 0;
            string colour = " ";
            var vehEngine = repository.GetEngine(engine);
            var car = new Car(model, vehEngine);

            if (input.Length > 2 && input.Length < 4)
            {
                weight = int.Parse(input[2]);
                repository.AddCar(car);
            }

            if (input.Length > 3)
            {
                colour = input[3];
                car._Colour = colour;
            }


        }
    }

    public void ReadCommand()
    {
       var instance = Activator.CreateInstance(Type.GetType("Car"));
    }

}


namespace _03BarracksFactory
{
    using Contracts;
    using Core;
    using Core.Factories;
    using Data;
    using P03_BarraksWars.Contracts.Core;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    class AppEntryPoint
    {
        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfigureService();

            ICommandInterpreter commandInterpreter = new CommandInterpreter(repository , unitFactory);
            IRunnable engine = new Engine(commandInterpreter);
            engine.Run();
        }

        private static IServiceProvider ConfigureService()
        {
            IServiceCollection service = new ServiceCollection();

            service.AddTransient<IUnitFactory , UnitFactory>();
            service.AddSingleton<IRepository, UnitRepository>();

            IServiceProvider serviceProvider = service.BuildServiceProvider();

            return serviceProvider;
        }
    }
}

using System;
using System.Linq;
using System.Reflection;

namespace Problem_2._Cars_Salesman
{
    class StartUp
    {
        static void Main(string[] args)
        {

           var engine = GetParts("Car");
         

            var commandInterpreter = new CommandInterpreter();

            commandInterpreter.ReadCommand();
        }

        private static object GetParts(string engine)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetTypes().FirstOrDefault(t => t.Name == engine);

            var part = Activator.CreateInstance(type);
            
            return type;
        }
    }
}

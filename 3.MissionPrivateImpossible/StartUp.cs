using System;

namespace _3.MissionPrivateImpossible
{
    class StartUp
    {
        static void Main()
        {
			var spy = new Spy();
			var result = spy.RevealPrivateMethods("Haker");
			Console.WriteLine(result);
        }
    }
}

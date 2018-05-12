using System;
using System.Collections.Generic;
using System.Text;

namespace _07.InfernoInfinity.interfaces
{
   public interface IGem
    {
        int Agility { get; }

        int Vitality { get; }

        int Strength { get; }

        GemClarity Clarity { get; }
    }
}

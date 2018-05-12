
using _07.InfernoInfinity.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.InfernoInfinity_interfaces
{
    public interface IWeapon
    {
        string Name { get; }

        int MinDamage { get; }

        int MaxDamage { get; }

        WeaponRarity Rarity { get; }

        IGem[] Sockets { get; }

        void AddGem(IGem gem, int socketIndex);

        void RemoveGem(int socketIndex);
    }
}

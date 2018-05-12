using _07.InfernoInfinity.interfaces;
using _07.InfernoInfinity_interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.InfernoInfinity.WeaponContracts
{
    public class Weapon : IWeapon, IGem
    {
        public Weapon(string rarity, string name)
        {
            this.Name = name;
            this.rarity = rarity;
        }
        public string Name { get; private set; }

        public int MinDamage { get; private set; }

        public int MaxDamage { get; private set; }

        public IGem[] gem { get; private set; }

        public int Agility { get; private set; }

        public int Vitality { get; private set; }

        public int Strength { get; private set; }
    }
}

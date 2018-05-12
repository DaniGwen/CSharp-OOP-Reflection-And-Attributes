using _07.InfernoInfinity.WeaponContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.InfernoInfinity_interfaces
{
    public class WeaponFactory

    {
        public object Iweapon { get; private set; }

        public IWeapon CreateWeapon()
        {
            var createInput = Console.ReadLine().Split(';');
            var Type = createInput[1].Split();

            var rarity = Type[0];
            var weaponType = Type[1];
            var weaponName = createInput[3];

            IWeapon weapon = new Weapon(rarity, weaponName);
        }

    }
}

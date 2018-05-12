using System;
using System.Collections.Generic;
using System.Text;

namespace _07.InfernoInfinity_interfaces
{
    public class Repository
    {
        private List<IWeapon> dataBase;

        public Repository(IWeapon weapon)
        {
            AddToRepository(weapon);
        }

        private void AddToRepository(IWeapon weapon)
        {
            if (!this.dataBase.Contains(weapon))
            {
                this.dataBase.Add(weapon);
            }

            throw new InvalidOperationException("Weapon already added!");
        }
    }
}

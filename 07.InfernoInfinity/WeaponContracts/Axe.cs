using _07.InfernoInfinity.interfaces;
using _07.InfernoInfinity.WeaponContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.InfernoInfinity_interfaces
{

    public class Axe : Weapon
    {
        private const int minimalDamage = 5;
        private const int maximalDamage = 10;

        private int minDamage;
        private int maxDamage;

        private IGem[] gems = new IGem[3];

        public Axe():base(rarity, name)
        {
           
            this.MinDamage = this.RarityDamageMin();
            this.MaxDamage = this.RarityDamageMax();

        }

        public Axe(IGem gemToAdd, int index): this()
        {
            AddGem(gemToAdd, index);
        }

        private void AddGem(IGem gem, int index)
        {
            try
            {
                if (index > 0 && index < 3)
                {
                    gems[index] = gem;
                }
            }
            catch (Exception)
            {

                return;
            }


        }

        public int MinDamage
        {
            get
            {
                return minDamage;
            }

            private set
            {
                minDamage = value;
            }
        }

        public int MaxDamage
        {
            get
            {
                return maxDamage;
            }
            private set
            {
                maxDamage = value;
            }
        }

        private int RarityDamageMax()
        {
            int damage;

            switch (this.rarity)
            {
                case "Common":
                    damage = maximalDamage * 1;
                    break;
                case "Uncommon":
                    damage = maximalDamage * 2;
                    break;
                case "Rare":
                    damage = maximalDamage * 3;
                    break;
                case "Epic":
                    damage = maximalDamage * 5;
                    break;
                default:
                    throw new ArgumentException("Invalid Rareness!");
            }

            return damage;
        }

        private int RarityDamageMin()
        {
            int damage;

            switch (this.rarity)
            {
                case "Common":
                    damage = minimalDamage * 1;
                    break;
                case "Uncommon":
                    damage = minimalDamage * 2;
                    break;
                case "Rare":
                    damage = minimalDamage * 3;
                    break;
                case "Epic":
                    damage = minimalDamage * 5;
                    break;
                default:
                    throw new ArgumentException("Invalid Rareness!");
            }

            return damage;
        }

        public int Agility { get; private set; }

        public int Vitality { get; private set; }

        public int Strength { get; private set; }

        public string name { get; private set; }

       public string rarity { get; private set; }
        
    }
}

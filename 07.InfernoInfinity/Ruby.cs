
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.InfernoInfinity.interfaces
{
    public class Ruby : IGem
    {
        public int agility = 2;
        public int vitality = 5;
        private int strength = 7;

        public Ruby(string condition)
        {
            this.GetCondition(condition);
        }

        public int Agility
        {
            get
            {
                return agility;
            }
            set
            {
                agility = value;
            }
        }

        public int Vitality
        {
            get
            {
                return vitality;
            }
            set
            {
                vitality = value;
            }
        }

        public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                strength = value;
            }
        }

        public void GetCondition(string condition)
        {
            switch (condition)
            {
                case "Chipped":
                    Agility += 1;
                    Vitality += 1;
                    Strength += 1;
                    break;
                case "Regular":
                    Agility += 2;
                    Vitality += 2;
                    Strength += 2;
                    break;
                case "Perfect":
                    Agility += 5;
                    Vitality += 5;
                    Strength += 5;
                    break;
                case "Flawless":
                    Agility += 10;
                    Vitality += 10;
                    Strength += 10;
                    break;
                default:
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBall
{
    public enum race
    {
        HUMAN,
        NAMEKIAN,
        SAIYAN,
        SUPER_SAIYAN
    }
    abstract class Fighter
    {
        private race _race;
        private string _name;
        private double _energy;
        private double _dodge; 

        public Fighter(string name, race race) 
        {
            _name = name;
            _race = race;
            _energy = Utils.GetRandom(1000, 2000);
            _dodge = Utils.GetRandom(0.1, 0.9);
        }

        public race Race => _race; 
        public string Name => _name;
        public double Energy => _energy;
        public double Dodge => _dodge;

        public void SubstractEnergy(double input)
        {
            _energy -= input;
        }

        abstract public void Attack(Fighter fighter);

        abstract public double DodgeChance();

        abstract public double BlockChance();

        public bool WantsDodge()
        {
            double chances = Utils.GetRandom(0, 1);
            if (chances < _dodge)
                return true;
            return false;
        }

        public void RecivesAttack(double blockDamage, double maxDamage)
        {
            if (WantsDodge() == true && DodgeChance() > Utils.GetRandom(0, 1))
                return;
            if (!WantsDodge() && BlockChance() > Utils.GetRandom(0, 1))
                SubstractEnergy(blockDamage);
            else
                SubstractEnergy(maxDamage);

        }
    }
}

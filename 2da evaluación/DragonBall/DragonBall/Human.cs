using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBall
{
    internal class Human:Fighter
    {
        private double _hitAttack;
        private double _dodgeCapacity;
        private double _blockCapacity; 

        public Human(string name):base(name, race.HUMAN)
        {
            _hitAttack = Utils.GetRandom(0.1, 0.8);
            _dodgeCapacity = Utils.GetRandom(0.4, 0.6);
            _blockCapacity = Utils.GetRandom(0.7, 0.9);
        }

        public override void Attack(Fighter fighter)
        {
            SubstractEnergy(1);
            fighter.RecivesAttack(0.5, 3);

        }

        public override double BlockChance()
        {
           return _blockCapacity;
        }

        public override double DodgeChance()
        {
            return _dodgeCapacity;
        }
    }
}

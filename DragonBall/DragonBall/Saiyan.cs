using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBall
{
    internal class Saiyan:Fighter
    {
        private double _beamAttack; 
        private double _hitAttack;
        private double _dodgeCapacity;
        private double _blockCapacity;

        private Random chooseAttack = new Random();

        public Saiyan(string name) : base(name, race.SUPER_SAIYAN)
        {
            _beamAttack = Utils.GetRandom(0.3, 0.6);
            _hitAttack = Utils.GetRandom(0.1, 0.8);
            _dodgeCapacity = Utils.GetRandom(0.2, 0.4);
            _blockCapacity = Utils.GetRandom(0.4, 0.9);

        }
        public override void Attack(Fighter fighter)
        {
            if (chooseAttack.Next(0, 10) > 5) //Golpe
            {
                SubstractEnergy(5);

                fighter.RecivesAttack(2, 7);
            }

            if (chooseAttack.Next(0, 10) < 6) //Rayo
            {
                SubstractEnergy(100);

                fighter.RecivesAttack(25, 300);

            }
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

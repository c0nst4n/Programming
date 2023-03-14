using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBall
{
    internal class Namekian:Fighter
    {
        private double _beamAttack;
        private double _hitAttack;
        private double _dodgeCapacity;
        private double _blockCapacity;

        public Namekian(string name):base(name, race.NAMEKIAN)
        {
            _beamAttack = Utils.GetRandom(0.1, 0.4);
            _blockCapacity = Utils.GetRandom(0.3, 0.6);
            _dodgeCapacity = Utils.GetRandom(0.5, 0.7);
            _hitAttack = Utils.GetRandom(0.1, 0.4);

        }

        private Random chooseAttack = new Random();

        public override void Attack(Fighter fighter)
        {
            if (chooseAttack.Next(0, 10) > 5) //Golpe
            {
                SubstractEnergy(5);

                fighter.RecivesAttack(7, 19);
            }

            if (chooseAttack.Next(0, 10) < 6) //Rayo
            {
                SubstractEnergy(100);

                fighter.RecivesAttack(20, 100);

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

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

        protected double _BeamBlockDamage = 25;
        protected double _BeamFullDamage = 300;
        protected double _HitBlockDamage = 2;
        protected double _HitFullDamage = 7;

        protected Random chooseAttack = new Random();

        public Saiyan(string name) : base(name, race.SAIYAN)
        {
            _beamAttack = Utils.GetRandom(0.3, 0.6);
            _hitAttack = Utils.GetRandom(0.1, 0.8);
            _dodgeCapacity = Utils.GetRandom(0.2, 0.4);
            _blockCapacity = Utils.GetRandom(0.4, 0.9);

        }

        protected Saiyan(string name, race rc) : base(name, rc)
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

                fighter.RecivesAttack(_HitBlockDamage, _HitFullDamage);
            }

            else //Rayo
            {
                SubstractEnergy(100);

                fighter.RecivesAttack(_BeamBlockDamage, _BeamFullDamage);

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

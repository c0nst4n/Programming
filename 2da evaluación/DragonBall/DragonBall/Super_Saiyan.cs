using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBall
{
    internal class Super_Saiyan:Saiyan
    {
        private double _beamAttack;
        private double _hitAttack;
        private double _dodgeCapacity;
        private double _blockCapacity;
        private int _attackQuantity;


        public Super_Saiyan(string name):base(name, race.SUPER_SAIYAN)
        {
            _attackQuantity = Utils.GetRandomInt(1, 3);
        }

        public void Attack(Fighter enemy)
        {
            for(int i = 0; i < _attackQuantity; i++)
            {
                if (chooseAttack.Next(0, 10) > 5) //Golpe
                {
                    SubstractEnergy(5);

                    enemy.RecivesAttack(_HitBlockDamage * 2, _HitFullDamage * 2);
                }

                if (chooseAttack.Next(0, 10) < 6) //Rayo
                {
                    SubstractEnergy(100);

                    enemy.RecivesAttack(_BeamBlockDamage * 2, _BeamFullDamage * 2);

                }
            }

        }
        
    }
}

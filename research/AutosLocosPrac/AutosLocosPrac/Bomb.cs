using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocosPrac
{
    internal class Bomb : Obstacle
    {
        private int _time;
        public Bomb(string name, double position, int time) : base(name, position)
        {
            _time = time;
            if (_time < 0)
                _time = 0;
        }

        public override void Simulate(IRace race)
        {
            do
            {
                _time -= 1;
            }
            while (_time > 0);

            if (_time == 0) 
            {
                RaceObject car = race.getCarBetween(Position, 50);

                if (car != null)
                {
                    car.ModifyPosition(Utils.rand.Next(-50, 50));
                }

                Disable();
            }
        }


    }
}

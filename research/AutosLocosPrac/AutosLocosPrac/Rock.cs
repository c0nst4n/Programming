using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocosPrac
{
    internal class Rock : Obstacle
    {
        private int _weight = Utils.rand.Next(10, 30);
        public Rock(string name, double position) : base(name, position)
        {
        }

        public override void Simulate(IRace race)
        {
            if (race.getCarAt(Position - 10) != null)
            {
                RaceObject car = race.getCarAt(Position - 10);

                int randresult = Utils.rand.Next(0, 100);

                if (randresult <= 10 + _weight)
                    car.ModifyPosition(-25);
            } 


        }
    }
}

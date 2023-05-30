using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocosPrac
{
    public class Puddle : Obstacle
    {
        public Puddle(string name, double position) : base(name, position)
        {

        }

        public override void Simulate(IRace race)
        {
           if (race.getCarAt(Position - 20) != null)
           {
               RaceObject car = race.getCarAt(Position - 20);
               int randresult = Utils.rand.Next(0, 100);
               
                if (randresult <= 20) 
                {
                    car.Disable(Utils.rand.Next(0,3));
                }

           }
        }
    }
}

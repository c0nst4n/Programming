using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocosPrac
{
    public class Obstacle : RaceObject
    {
        public Obstacle(string name, double position):base(name, position, ObjectType.OBSTACLE)
        {

        }
        
        public override ObjectType GetObjectType()
        {
            return Type;
        }

        public override bool IsEnabled()
        {
            return isEnabled;
        }

        public override void Simulate(IRace race)
        {
            throw new NotImplementedException();
        }
    }
}

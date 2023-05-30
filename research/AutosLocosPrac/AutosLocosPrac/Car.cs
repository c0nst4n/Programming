using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocosPrac
{
    public class Car : RaceObject
    {
        protected int finetunning;
        public Car(string name, double position, int finetunning) : base(name, position, ObjectType.CAR)
        {
            this.finetunning = finetunning;
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

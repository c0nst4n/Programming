using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocosPrac
{
    public class GlamourCar:Car
    {
        public GlamourCar(string name, double position, double finetunning) : base(name, position, Utils.DoubleRand(0.0,3.0))
        {

        }

        public override void Simulate(IRace race)
        {
            ModifyPosition(20);
        }


    }
}

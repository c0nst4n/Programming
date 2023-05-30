using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocosPrac
{
    public class Animal:Driver
    {
        public override double GetVelocityExtra()
        {
            return 3.0;
        }
    }
}

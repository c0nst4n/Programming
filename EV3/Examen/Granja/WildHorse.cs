using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class WildHorse:Horse
    {
        public WildHorse(bool IsVaccined, int id, Zone zone, double weight) : base(IsVaccined, id, zone, weight)
        {

        }

        public override double GetQualification()
        {
            return Wieght / 2;
        }
    }
}

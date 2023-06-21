using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class WildHorse:Horse
    {
        public WildHorse(bool IsVaccined, string id, Zone zone, double weight, Date PasturationDate) : base(IsVaccined, id, zone, weight, PasturationDate)
        {

        }

        public override double GetQualification()
        {
            return Wieght / 2;
        }
    }
}

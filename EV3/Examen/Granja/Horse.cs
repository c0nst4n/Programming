using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public abstract class Horse:Animal, ITerrestial
    {
        public Horse(bool IsVaccined, int id, Zone zone, double weight) : base(IsVaccined, id, zone, weight)
        {

        }

        public abstract double GetQualification();
    }
}

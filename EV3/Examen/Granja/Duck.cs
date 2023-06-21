using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Duck:Flying
    {
        public Duck(bool IsVaccined, string id, Zone zone, double weight, Date eggDate) : base(IsVaccined, id, zone, weight, eggDate)
        {
        }

        public override bool IsTerrestial()
        {
           return false;
        }

        public bool IsFlying() 
        {
            return true;
        }
    }
}

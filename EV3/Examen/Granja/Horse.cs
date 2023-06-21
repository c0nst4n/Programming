using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public abstract class Horse:Animal, ITerrestial
    {
        protected Date _pasturationDate;
        public Horse(bool IsVaccined, string id, Zone zone, double weight, Date PasturationDate) : base(IsVaccined, id, zone, weight)
        {
            _pasturationDate = PasturationDate;
        }

        public abstract double GetQualification();

        public bool IsFlying()
        {
            return false;
        }

        public override string GetInfo()
        {
            string str = AnimToString() + "\n";
            string Qualif ="Su cualificación es: " + GetQualification().ToString() + "\n";    

            return str + Qualif;
        }

        public string GetPasturationDate()
        {
            return _pasturationDate.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class DomesticatedHorse:Horse, ITerrestial
    {
        private Date _domesticationDate;
        public DomesticatedHorse(bool IsVaccined, int id, Zone zone, double weight, Date domesticationDate) : base(IsVaccined, id, zone, weight)
        {
            _domesticationDate = domesticationDate;
        }

        public override double GetQualification()
        {
            return  (double)_domesticationDate.Year;   
        }
    }
}

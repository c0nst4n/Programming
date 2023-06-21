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
        public DomesticatedHorse(bool IsVaccined, string id, Zone zone, double weight, Date PasturationDate, Date domesticationDate) : base(IsVaccined, id, zone, weight, PasturationDate)
        {
            _domesticationDate = domesticationDate;
        }

        public override double GetQualification()
        {
            return  (double)_domesticationDate.Year;   
        }
    }
}

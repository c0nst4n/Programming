using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Flying:Animal, IFlying
    {
        private Date _eggDate;

        public Flying(bool IsVaccined, int id, Zone zone, double weight, Date eggDate) : base(IsVaccined, id, zone, weight)
        {
            _eggDate = eggDate;
        }
        public Date ReturnDate()
        {
            return _eggDate;
        }
    }
}

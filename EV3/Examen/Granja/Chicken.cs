using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Chicken :Flying, ITerrestial 
    {
        // Javi: Faltan cosas
        public Chicken(bool IsVaccined, int id, Zone zone, double weight, Date eggDate) : base(IsVaccined, id, zone, weight, eggDate)
        { 
        }

        //public Date ReturnDate()
        //{
        //    return _eggDate;
        //}
    }
}

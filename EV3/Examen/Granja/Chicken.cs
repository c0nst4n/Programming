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
        private Date _PasturationDate;
        public Chicken(bool IsVaccined, string id, Zone zone, double weight, Date eggDate, Date PasturationDate) : base(IsVaccined, id, zone, weight, eggDate)
        {
            _PasturationDate = PasturationDate;
        }

        //falta el isterrestial y el isFlying
            //hecho en la clase padre Flying
        //sobreescribir el metodo toString modificando valores
            //Hecho en la clase padre Flying

        public bool IsFlying()
        {
            return true;
        }

        public override bool IsTerrestial()
        {
            return true;
        }
        public string GetPasturationDate()
        {
            return _PasturationDate.ToString();
        }

        public override string GetInfo()
        {
            string datepasting = "La última vez en la que salió a pastar fue: " + GetPasturationDate() + "\n";
           return base.GetInfo() + datepasting;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public abstract class Flying:Animal, IFlying
    {
        private Date _eggDate;
        public Flying(bool IsVaccined, string id, Zone zone, double weight, Date eggDate) : base(IsVaccined, id, zone, weight)
        {
            _eggDate = eggDate;
        }
        public string ReturnEggDate()
        {
            return _eggDate.ToString();
        }
        
        //añadir metodo toString que sume el eggDate
            //Hecho

        public override string GetInfo()
        {
            string date = "La fecha de la última vez que puso un huevo es: " + ReturnEggDate() + "\n";
            string info = AnimToString();
            
            return info + date;
        }


        public abstract bool IsTerrestial();


    }
}

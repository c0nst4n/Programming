using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    //public enum AnimalType
    //{
    //    NONE,
    //    NORMAL,
    //    FLYING,
    //    TERRESTIAL
    //}
    public class Animal
    {
        private bool _isVaccinated;
        private int _id;
        private Zone _zone;
        private double _wieght;
        //private AnimalType _type1;
        //private AnimalType _type2;

        public bool IsVaccinated => _isVaccinated;
        public int Id => _id;
        public Zone Zone => _zone;
        public double Wieght => _wieght;
        //public AnimalType Type1 => _type1;
        //public AnimalType Type2 => _type2;

        public Animal(bool IsVaccined, int id, Zone zone, double weight /*AnimalType t1, AnimalType t2*/)
        {
            _isVaccinated = IsVaccined;
            _id = id;
            _zone = zone;
            _wieght = weight;
            //_type1 = t1;
            //_type2 = t2;
        }
        public void ModifyWight(double modifyer)
        {
            _wieght += modifyer;
        }

        public void ChangeLocation(Zone newzone)
        {
            _zone = newzone;
        }

        //public bool IsTerestial()
        //{
        //    return _type1 == AnimalType.TERRESTIAL || _type2 == AnimalType.TERRESTIAL;
        //} 
        //public bool IsFlying()
        //{
        //    return _type1 == AnimalType.FLYING || _type2 == AnimalType.FLYING;
        //}

        // Javi: Este método no lo quería aquí
        public override string ToString()
        {
            string info = "";

            info += "Su ID es: " + _id;

            if(IsVaccinated)
                info += "Esta vacunado \n";
            if (!IsVaccinated)
                info += "No esta vacunado \n";

            //info +="su tipo es: " + _type1.ToString() + "\n";

            //if (_type2 != AnimalType.NONE)
            //    info += "su 2do tipo es: " + _type2.ToString() + "\n";

            info += "Esta en " + _zone + "\n";

            info +="Pesa: " + _wieght + "\n";


            return info;
        }


    }
}

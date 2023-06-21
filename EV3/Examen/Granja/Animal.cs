using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{

    public abstract class Animal
    {
        private bool _isVaccinated;
        
        
        private string _id;
        private Zone _zone;
        private double _wieght;

        public bool IsVaccinated => _isVaccinated;
        public string Id => _id;
        public Zone Zone => _zone;
        public double Wieght => _wieght;


        public Animal(bool IsVaccined, string id, Zone zone, double weight)
        {
            _isVaccinated = IsVaccined;
            _id = id;
            _zone = zone;
            _wieght = weight;

        }
        public void ModifyWight(double modifyer)
        {
            _wieght = modifyer;
        }

        public void ChangeLocation(Zone newzone)
        {
            if (newzone != null)
                _zone = newzone;
        }



        protected string AnimToString()
        {
            string info = "";

            info += "Su ID es: " + _id + "\n";

            if(_isVaccinated)
                info += "Esta vacunado \n";
            if (!_isVaccinated)
                info += "No esta vacunado \n";



            info += "Esta en " + _zone.Name + "\n";

            info +="Pesa: " + _wieght.ToString() +" kg" +"\n";


            return info;
        }

        public abstract string GetInfo();
        public string GetId()
        {
            return _id;
        }

        public  Zone GetZone()
        {
            return _zone;
        }
    }
}

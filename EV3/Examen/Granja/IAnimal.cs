using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public interface IAnimal
    {
        //añadir metodos de volador o terrestre 
            //Hehcho

        public bool IsFlying();

        public bool IsTerrestial();

        public string GetId();

        public void ChangeLocation(Zone newzone);

        public Zone GetZone();
    }
}

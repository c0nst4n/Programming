using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public interface ITerrestial:IAnimal
    {
        public string GetPasturationDate();
      
        //implementar solo el IsTerrestial
            //Hecho

        bool IAnimal.IsTerrestial()
        {
            return true;
        }
    }
}

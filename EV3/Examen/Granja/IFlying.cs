using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public interface IFlying:IAnimal
    {
        public string ReturnEggDate();
        
        //implementar solo el isFlying
            //Hecho

        bool IAnimal.IsFlying()
        {
            return true;
        }


    }
}

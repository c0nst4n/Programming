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
        public Date ReturnDate();

        public bool IsFlying()
        {
            return true;
        }

        // Javi: No estoy de acuerdo
        public bool IsTerrestial()
        {
            return false;
        }

    }
}

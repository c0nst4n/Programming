using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public interface ITerrestial
    {
        public bool IsFlying()
        {
            return false;
        }

        public bool IsTerrestial()
        {
            return true;
        }
    }
}

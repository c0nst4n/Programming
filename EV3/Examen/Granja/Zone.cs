using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Zone
    {
        private string _name;
        private string _direction;

        public Zone(string name, string direction) 
        {
            _name = name;
            _direction = direction;
        }
    }
}

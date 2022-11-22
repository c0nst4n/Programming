using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulation
{
    public enum Type
    {
        marathon,
        speedster,
        thief
    }
    public class Racer
    {
        public string name;
        public double position;
        public Type type;
    }
}

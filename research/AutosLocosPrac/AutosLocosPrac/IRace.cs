using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocosPrac
{
    public  interface IRace
    {
        public void Init(double distance);

        public List<RaceObject> Simulate();

        public void PrintDrivers();

        public int GetObjectCount();

        public int GetObjectAt(double index);

        public RaceObject getCarAt(double position);

        public RaceObject getCarBetween(double position, double amount);
    }
}

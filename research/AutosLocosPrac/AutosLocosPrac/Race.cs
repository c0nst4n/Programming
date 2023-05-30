using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocosPrac
{
    public class Race : IRace
    {
        List<RaceObject> ro = new List<RaceObject>();

        public RaceObject getCarAt(double position)
        {
            for (int i = 0; i < ro.Count; i++)
            {
                if (ro[i].GetObjectType() == ObjectType.CAR && ro[i].Position == position)
                    return ro[i];
            }
            return null;
        }

        public RaceObject getCarBetween(double position, double amount)
        {
            for (int i = 0; i < ro.Count; i++)
            {
                if (ro[i].GetObjectType() == ObjectType.CAR && (ro[i].Position >= position - amount || ro[i].Position <= position + amount))
                    return ro[i];
            }
            return null;
        }
        public int GetObjectAt(double index)
        {
            throw new NotImplementedException();
        }
        public int GetObjectCount()
        {
            throw new NotImplementedException();
        }

        public void Init(double distance)
        {
            throw new NotImplementedException();
        }

        public void PrintDrivers()
        {
            throw new NotImplementedException();
        }


        List<RaceObject> IRace.Simulate()
        {
            throw new NotImplementedException();
        }
    }
}

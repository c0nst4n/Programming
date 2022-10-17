using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulation
{
    internal class Simulation
    {
       public static List<Racer> GenerateRacers()
        {
            List<Racer> list = new List<Racer>();
            Racer r1 = new Racer();
            r1.name = "el pepe";
            r1.position = 0;
            list.Add(r1);
            Racer r2 = new Racer();
            r2.name = "Ete sech";
            r2.position = 0;
            list.Add(r2);
            return list;
        }

        public static Racer CheckWinner(List<Racer> racerList)
        {
            for(int i = 0; i < racerList.Count; i++)
            {
                Racer r = racerList[i];
                if (r.position >= 1000)
                {
                    return r;
                }
            }
            return null;
        }

        public static void Run(List<Racer> racerList)
        {
            for(int i = 0; i < racerList.Count; i++)
            {
                Racer r = racerList[i];
                    r.position += 10;
            }


        }
    }
}

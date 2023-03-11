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
            r1.name = "Juan";
            r1.position = 0;
            r1.type = Type.marathon;
            list.Add(r1);
            Racer r2 = new Racer();
            r2.name = "Mario";
            r2.position = 0;
            r2.type = Type.speedster;
            list.Add(r2);
            Racer r3 = new Racer();
            r3.name = "Eustaquio";
            r3.position = 0;
            r3.type = Type.thief;
            list.Add((Racer)r3);
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
                switch (r.type)
                {
                    case Type.marathon:
                        r.position += utils.GetRandom(3, 6);
                        break;
                    case Type.speedster:
                        r.position += utils.GetRandom(1, 7);
                        break;
                    default:
                        r.position += utils.GetRandom(0, 9);
                        break;
                }
            }


        }

    }
}

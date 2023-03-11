using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBall
{
    internal class Tournament:ITournament
    {
        List<Fighter> FList= new List<Fighter>();

        
        public void Init() 
        {
            for(int i=0; i < 16; i++)
            {
                int _random = Utils.GetRandomInt(0, 3);
                switch (_random)
                {
                    case 0:
                        FList.Add(new Human(i.ToString())); 
                        break;
                    case 1:
                        FList.Add(new Namekian(i.ToString()));
                        break;
                    case 2:
                        FList.Add(new Saiyan(i.ToString()));
                        break;
                    default:
                        FList.Add(new Super_Saiyan(i.ToString()));
                        break;

                }
                   

            }

        }

        public Fighter Combat(Fighter f1, Fighter f2)
        {
          

            while(true)
            {
                f1.Attack(f2);
                f2.Attack(f1);

                if (f2.Energy <= 0)
                {
                    return f1;
                }

                if(f1.Energy <= 0)
                {
                    return f2;
                }
            }  
        }

        public List<string> Execute() 
        {
            List<string> result = new List<string>();
          
            
            while(FList.Count > 1)
            {
                List<Fighter> next = new List<Fighter>();

                for (int i = 0; i< FList.Count; i+=2) 
                {
                    Fighter f1= FList[i];
                    Fighter f2 = FList[i+1];
                    Fighter Winner = Combat(f1, f2);
                    next.Add(Winner);
                    result.Add(f1.Name + " " + f1.Race + " vs " + f2.Name + " " + f2.Race + " ----> " + Winner.Name + "\n");
                }
                FList = next;
            }

            return result;
        }

        public void SeeResults()
        {
            List<string> results = Execute();
            for(int i=0; i < results.Count; i++)
            {
                Console.Write(results[i]);
            }
        }

        public void visit()
        {
           for(int i = 0; i < 16; i++)
            {
                Console.WriteLine(FList[i].Name + FList[i].Race);
            }
        }
    }
}

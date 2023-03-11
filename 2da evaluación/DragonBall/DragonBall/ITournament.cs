using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBall
{
    internal interface ITournament
    {
        public void Init();

        public List<string> Execute();

        public void visit();

        public Fighter Combat(Fighter f1, Fighter f2);
    }
}

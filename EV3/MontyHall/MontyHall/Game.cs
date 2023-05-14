using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    #region atributos
    public enum GameResult
    {
        WIN,
        LOSE
    }
    enum Door
    {
        CAR,
        GOAT
    }

    public class Game
    {
        private List<Door> _doorList = new List<Door>();
        private Random _rand= new Random();
        #endregion
    #region funciones
        public void Init()
        {
           _doorList.Add(Door.CAR);
           _doorList.Add(Door.GOAT);
           _doorList.Add(Door.GOAT);
        }


        public GameResult Execute(bool wantsChange)
        {
            Init();
            int select1 = _rand.Next(0, _doorList.Count - 1);
            

            if (_doorList[select1] == Door.GOAT && wantsChange)
            {
                _doorList.RemoveAt(select1);
              int select2 = _rand.Next(0, _doorList.Count - 1);

                if (_doorList[select2] == Door.GOAT)
                    return GameResult.LOSE;
                if (_doorList[select2] == Door.CAR)
                    return GameResult.WIN;
            }
            int personalChoice = _rand.Next(0, _doorList.Count - 1);
            if (_doorList[personalChoice] == Door.CAR)
                return GameResult.WIN;

            return GameResult.LOSE;
        }

    }
}
#endregion

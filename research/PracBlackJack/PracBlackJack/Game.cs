using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracBlackJack
{
    public class Game
    {
       private List<Player> _players= new List<Player>();
       private Random _rand = new Random();
        private int _bet = 0;
        public void Innit()
        {
            Bank b = new Bank(new card(1));
            _players.Add(b);
            for (int i = 0; i < 3; i++) 
            {
                _players.Add(new Player(b.GiveCard()));
            }
        }


        public bool IsItOver()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                if (_players[i].IsPlanted() == false)
                    return false;
            }

            if (_players == null) 
            {
                return true;
            }


        }
        public void TakeOutPlayers()
        {
            for (int i = 0; i < _players.Count; i++) 
            {
                if (_players[i].HasLost == true)
                {
                    _players.RemoveAt(i);
                    i--;
                }

            }
        }

        public void ModifyBet(int quantity)
        {
            _bet += quantity;
        }

        public void ResetBet()
        {
            _bet = 0;
        }
    }
}

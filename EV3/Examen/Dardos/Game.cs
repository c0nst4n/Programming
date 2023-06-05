using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dardos
{
    public class Game
    {
        List<Player> _players = new List<Player>();

        private int _bet = 0;
       
        public void InsertPlayer(Player p)
        {
            if (p != null)
                _players.Add(p);
        }

        public void Play()
        {
            if (_players.Count >= 2)
            {
                while (IsGameOver() == false)
                {
                    PlayRound();
                    AwardWinner();
                   if (IsThereGrandious())
                        GiveGrandiousArrows();
                    else
                    {
                        ResetArrows();
                    }
                    ResetGrandious();
                    ResetScore();
                    TakeOutPlayers();
                }
            }
        }
        public void PlayRound()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                _players[i].Bet(_bet);
                _players[i].Throw();
            }
        }
        public void AwardWinner()
        {
            Player p = _players[0];

            for (int i = 0; i < _players.Count; i++)
            {
                if (p.Score < _players[i].Score)
                    p = _players[i];
            }
            p.AddCoins(_bet);
        }

        public bool IsGameOver()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                if (_players[i].Coins == 100 * _players.Count - 1)
                    return true;
            }

            return false;
        }
        public bool IsThereGrandious()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                if (_players[i].IsGrandiose)
                    return true;
            }
            return false;
        }

        public void GiveGrandiousArrows()
        {
            for(int i = 0; i < _players.Count; i++)
            {
                if (_players[i].IsGrandiose)
                    _players[i].AddArrow();
                else
                    _players[i].setArrows(2);
            }
        }

        public void ResetGrandious()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                _players[i].ResetGrandiose();
            }
        }

        public void ResetArrows()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                _players[i].setArrows(3);
            }
        }

        public void ResetScore()
        {
            for(int i = 0; i < _players.Count; i++)
            {
                _players[i].resetScore();
            }
        }

        public void TakeOutPlayers()
        {
            for(int i = 0; i < _players.Count; i++)
            {
                if (_players[i].Coins <= 0)
                {
                    _players.RemoveAt(i);
                    i--;
                }
            }
        }
        //public void ModifyBet(int modyfier)
        //{
        //    _bet += _bet;
        //}
    }
}

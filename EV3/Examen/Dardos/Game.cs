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
            if (p != null || !FindPlayer(p))
                _players.Add(p);
        }

        public bool FindPlayer (Player p)
        {
            for (int i = 0; i < _players.Count; i++)
            {
                if (_players[i] == p)
                    return true;
            }

            return false;
        }
        public string Play()
        {
            string winner;
            while (IsGameOver() == false)
            {
                _bet = 0;
                BetRound();
                PlayRound();
                AwardWinner();
                if (IsThereGrandious())
                    GiveGrandiousArrows();
                else
                    ResetArrows();

                ResetGrandious();
                ResetScore();
                TakeOutPlayers();
            }

            winner = _players[0].Name;
            return winner;
        }
        public void PlayRound()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                _players[i].Throw();
            }
        }

        public void BetRound()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                _players[i].Bet(ref _bet);

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
            return _players.Count == 1;

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
            for (int i = 0; i < _players.Count; i++)
            {
                if (_players[i].IsGrandiose)
                    _players[i].AddArrow();
                else
                    _players[i].SetArrows(2);
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
                _players[i].SetArrows(3);
            }
        }

        public void ResetScore()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                _players[i].ResetScore();
            }
        }

        public void TakeOutPlayers()
        {
            for (int i = 0; i < _players.Count; i++)
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

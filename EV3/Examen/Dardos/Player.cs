using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dardos
{

    public class Player
    {
        private string _name;
        private int _id;
        private int _coins = 100;
        private int _arrows = 3;
        private bool _IsGrandiose = false;

        private Random _rand = new Random();
        private int _score = 0;
        private int _skill;
        public string Name => _name;
        public int Id => _id;
        public int Coins => _coins;
        public bool IsGrandiose => _IsGrandiose;
        public int Score => _score;


        public int Skill => _skill;
        public Player(string name, int id, int skill)
        {
            _name = name;
            _id = id;
            _skill = skill;
            if (_skill <= 0)
                _skill = 10;
            if (_skill >= 25)
                _skill = 25;
        }

        public void Bet(int gamebet)
        {
            if (_coins >= 5)
            {
                int bet = _rand.Next(5, _coins);
               _coins -= bet;
                gamebet += bet;
            }
            else
            {
                int bet = _coins;
                _coins = 0;
                gamebet += bet;
            }
        }

        public void resetScore()
        {
            _score = 0;
        }

        public void Throw()
        {
            for (int i = 0; i < _arrows; i++)
            {
                int shot = _rand.Next(0, 100) + _skill;

                if (shot == 0)
                    _score += 0;
                if (shot <= 1 && shot >= 30)
                    _score += 1;
                if (shot <= 30 && shot >= 60)
                    _score += 5;
                if (shot <= 60 && shot >= 90)
                    _score += 10;
                if (shot <= 90 && shot >= 100)
                    _score += 50;
                if (shot < 100)
                {
                    _score += 100;
                    _IsGrandiose = true;
                }
                    

            }
        }

        public void setArrows(int arrowNum)
        {
            _arrows = arrowNum;
        }

        public void AddArrow()
        {
            _arrows++;
        }

        public void ResetGrandiose()
        {
            _IsGrandiose = false;
        }

        public void AddCoins(int quantity)
        {
            _coins += quantity;
        }
    }
}

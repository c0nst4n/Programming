using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracBlackJack
{
    public class Player
    {
        private Deck _deck = new Deck();
        private int _chips;
        private string _name;
        private bool _isPlanted = false;
        private bool _hasLost = false;
        public bool HasLost => _hasLost;
        public Deck deck => _deck;  

        public Player(card c)
        {
            _deck.AddCard(c);
        }

        public bool IsTotalGreaterThan21()
        {
            return _deck.GetScore() > 21;
        }

        public void Plant()
        {
            _isPlanted= true;
        }

        public void Unplant()
        {
            _isPlanted= false;
        }

        public bool HasChips()
        {
            return _chips > 0;
        }
        public void AskForCard()
        {
            _chips--;
            if (IsTotalGreaterThan21())
                _hasLost = true;
        }

        public bool IsPlanted()
        {
            return _isPlanted;
        }
    }
}

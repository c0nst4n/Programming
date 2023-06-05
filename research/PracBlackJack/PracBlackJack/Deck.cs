using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracBlackJack
{
    public class Deck
    {
        private List<card> _cards = new List<card>();

        public void AddCard(card c)
        {
            if (c != null  || !_cards.Contains(c))
            _cards.Add(c);
        }

        public void RemoveCard(card c)
        {
            if (c != null)
            _cards.Remove(c);
        }

        public void RemoveIndexCard(int index)
        {
            if (index >= 0)
            {
                for (int i = 0; i < _cards.Count; i++)
                {
                    if (index == i)
                        _cards.RemoveAt(i);
                }
            }
        }

        public card SelectIndexCard(int index)
        {
            if (index >= 0)
            {
                for (int i = 0; i < _cards.Count; i++)
                {
                    if (index == i)
                        return _cards[i];
                }
            }
            return null;
        }


        public int GetScore()
        {
            int total = 0;
            for (int i = 0; i <= _cards.Count; i++)
            {
                total += _cards[i].GetValue();
            }
            return total;
        }

        public int GetLength()
        {
            return _cards.Count;
        }
    }
}

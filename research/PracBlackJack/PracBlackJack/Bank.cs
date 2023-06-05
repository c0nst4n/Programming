using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracBlackJack
{
    public class Bank:Player
    {
        private Deck _bankDeck = new Deck();
        public Deck BankDeck => _bankDeck;

        private Random _random = new Random();
        public Bank(card c):base(c)
        {
            for(int j = 0; j < 4; j++)
            {
                for (int i = 1; i < 10; i++)
                {
                    deck.AddCard(new card(i));
                }

                for (int i = 0; i < 2; i++)
                {
                    deck.AddCard(new FigureCard());
                }
            }
        }

        public void Swap(card a, card c)
        {
            card b = a;
            a = c;
            c = b;

            
        }
        public void ShuffleBankCards()
        {
            for (int i = 0; i < _bankDeck.GetLength(); i++)
            {
                int rand1 = _random.Next(0, _bankDeck.GetLength() - 1);
                int rand2 = _random.Next(0, _bankDeck.GetLength() - 1);

                Swap(_bankDeck.SelectIndexCard(rand1), _bankDeck.SelectIndexCard(rand2));
            }
        }

        public card GiveCard()
        {
  
           card c = _bankDeck.SelectIndexCard(_random.Next(0, _bankDeck.GetLength() - 1));
            return c;
        }
    }
}

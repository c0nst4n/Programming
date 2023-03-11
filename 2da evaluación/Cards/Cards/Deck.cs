using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cards
{
    public class Deck
    {
        private List<Paper> _CardList = new List<Paper>();

        // Javi: MAL!!!!!!!
        public List<Paper> CardCount => _CardList;

        // Javi: Mal nombre
        public Paper GetCardPosition(int pos)
        {
            return _CardList[pos];
        }

        // Javi: Función incorrecta, no hace falta un bucle
        public void ExtractCard(int pos)
        {
            for (int i = 0; i < _CardList.Count; i++)
            { 
                if (i == pos)
                {
                    _CardList.RemoveAt(i);
                }
            }
        }

        public void ExtractExactCard(int num, CardType type)
        {
            for (int j = 0; j < _CardList.Count; j++)
            {
                if (_CardList[j].Num == num && _CardList[j].CType == type)
                    _CardList.Remove(_CardList[j]);
            }
        }

        public void AddCard(Paper InputCard)
        {
            for(int i = 0; i < _CardList.Count; i++)
            {
                if (InputCard == _CardList[i])
                    return;
                // Javi: MAL!!!!!
                _CardList.Add(InputCard);
            }
        }

        // Javi: Mal nombre
        public void AddCardWStats(int num, CardType type)
        {
            for(int i = 0; i < _CardList.Count; i++)
            {
                if (_CardList[i].CType == type && _CardList[i].Num == num)
                    return;
                // Javi: MAL!!!!!!!
                _CardList.Add(new Paper(num, type));
            }

        }

        public void SwapCards(Paper num1, Paper num2)
        {
            Paper aux = num1;
            num1 = num2;
            num2 = aux;
        }

        // Javi: Demasiados intros
        public void ShuffleCards()
        {


            for(int i = 0; i < _CardList.Count; i++)
            {
                int rand1 = Utils.GetRandomInteger(0, _CardList.Count - 1);
                int rand2 = Utils.GetRandomInteger(0, _CardList.Count - 1);

                SwapCards(_CardList[rand1], _CardList[rand2]);

            }

        }

        // Javi: QUE?!?!?!?!!??!!?!?!?
        public List<Paper> ExtractCardList(int number)
        {
            List<Paper> Extractedcards = new List<Paper>();

            for(int i=0; i<number; i++)
            {
                _CardList.RemoveAt(i);
                Extractedcards.Add(_CardList[i]);
            }

            return Extractedcards;
        }

        public void Reset()
        {
            List<Paper> papers = new List<Paper>();

            for(int i = 0; i < 12; i++)
            {
                papers.Add(new Paper(i, CardType.GOLD));
            }

            for (int i = 0; i < 12; i++)
            {
                papers.Add(new Paper(i, CardType.SWORDS));
            }

            for (int i = 0; i < 12; i++)
            {
                papers.Add(new Paper(i, CardType.CUPS));
            }

            for (int i = 0; i < 12; i++)
            {
                papers.Add(new Paper(i, CardType.STICK));
            }
        }

    }
}

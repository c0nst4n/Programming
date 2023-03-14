
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafetera
{
    internal class Cafetera
    {
        private int _MaxCapacity;
        private int _PresentAmount;

        
        public Cafetera() //Vacío
        {
            _MaxCapacity = 1000;
            _PresentAmount = 0;
        }

        public Cafetera(int amount) //Inicializa la capacidad igual a la cantidad
        {
            _MaxCapacity = amount;
        }

        public Cafetera(int capacity, int amount)
        {
            _MaxCapacity = capacity;
            _PresentAmount = amount;

            if (amount > capacity)
                _MaxCapacity = _PresentAmount;

        }

        public void FillCoffeMaker()
        {
            _PresentAmount = _MaxCapacity;
        }

       /* public int ServeCup(int CupCapacity, int cupDrink)
        {
            int difference = _PresentAmount - cupDrink;


        }*/

        public void EmptyCoffe()
        {
            _PresentAmount = 0;
        }


        public int giveCoffee(int given)
        {
            return _PresentAmount + given;
        }



    }
}

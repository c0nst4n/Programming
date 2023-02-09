using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour
{
    internal class Comunity
    {
        private List<House> _HouseList= new List<House>();
        private string _street;
        private int _number;
        private string _postalCode;
        private string _city;

        public int NumberOfLivings
        {
            get => _HouseList.Count;
        }

        public int GetNumberOfPeople
        {
            get
            {
                return _HouseList.GetPeopleQuantity;
            }
        }

        public int GetPersonCount()
        {
            int result = 0;
            for (int i = 0; i < _HouseList.Count; i++) {
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Stable:Zone
    {
       private List<Animal> _animals = new List<Animal>();   
        public Stable(string name, string direction) : base(name, direction)
        {

        }

        public Animal GetAnimalByID(int ID)
        {
            if (ID < 0)
                return null;
            return _animals[ID];
        }

        public void AddAnimal(Animal a)
        {
            if(a != null)
                _animals.Add(a);
        }

        public void DeleteAnimal(Animal a)
        {
            if (a != null && _animals.Contains(a))
                _animals.Remove(a);
        }

        public int GetAnimalCount()
        {
            return _animals.Count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Stable:Zone
    {
       private List<IAnimal> _animals = new List<IAnimal>();   
        public Stable(string name, string direction) : base(name, direction)
        {

        }

        //rehacer para que funcione con strings
        //Hecho
        public IAnimal GetAnimalByID(string ID)
        {
            for (int i = 0; i < _animals.Count; i++) 
            {
                if (_animals[i].GetId() == ID)
                    return _animals[i];
            }
            return null;
        }

        public void AddAnimal(IAnimal a)
        {
            if(a != null && !IsAnimalAtStable(a))
            {
                _animals.Add(a);
                a.ChangeLocation(this);
            }
                
        }


        public void DeleteAnimal(IAnimal a)
        {
            if (a != null && IsAnimalAtStable(a))
                for (int i = 0; i < _animals.Count; i++)
                {
                    if (a == _animals[i])
                        _animals.RemoveAt(i);
                }

        }

        public void ChangeAnimalsLocation()
        {
            for (int i = 0; i < _animals.Count; i++)
            {
                if (_animals[i].GetZone() != this)
                    DeleteAnimal(_animals[i]);
                
            }
        }

        public bool IsAnimalAtStable(IAnimal a)
        {
            return GetIndexOf(a) != -1;
        }
        public int GetAnimalCount()
        {
            return _animals.Count;
        }
        
        //faltan metodos
            //Hecho?

        //falta el getAnimalAt
            //Hecho

        public IAnimal GetAnimalAt(int index)
        {
            if (index <= 0 && index <= _animals.Count)
            {
                for (int i = 0; i < _animals.Count; i++)
                {
                    if (i == index)
                        return _animals[i];
                } 
            }
            return null;


        }

        public void DeleteAnimalAt(int index)
        {
           IAnimal a = GetAnimalAt(index);

            if (a != null)
                DeleteAnimal(a);
        }

        public int GetIndexOf(IAnimal a)
        {
            if (a != null)
            {
                for (int i = 0; i < _animals.Count; i++)
                {
                    if (a == _animals[i])
                        return i;
                }
            }
            return -1;
        }
    }
}

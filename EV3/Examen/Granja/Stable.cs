using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Stable : Zone
    {
        private List<IAnimal> _animals = new List<IAnimal>();
        public Stable(string name, string direction) : base(name, direction)
        {

        }

        //rehacer para que funcione con strings
        //Hecho
        public IAnimal? GetAnimalByID(string ID)
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
            if (a != null && !IsAnimalAtStable(a))
            {
                _animals.Add(a);
                a.ChangeLocation(this);
            }

        }

        //He puesto el i-- que me faltaba
        public void DeleteAnimal(IAnimal a)
        {
            if (a != null && IsAnimalAtStable(a))
                for (int i = 0; i < _animals.Count; i++)
                {
                    if (a == _animals[i])
                    {
                        _animals.RemoveAt(i);
                        i--;
                    }
                        
                }

        }
        //He puesto el i-- que me faltaba
        public void ChangeAnimalsLocation()
        {
            for (int i = 0; i < _animals.Count; i++)
            {
                if (_animals[i].GetZone() != this)
                {
                    DeleteAnimal(_animals[i]);
                    i--;
                }
                   

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

        //CORREGIR ESTO IMPORTANTE Y PONER PORQUE ESTABA MAL
        //La razón por la que esto estaba mal es porque no hacía falta recorrer
        //el bucle en primer lugar, sobra decir que castigaré mi cuerpo de la forma
        //mas ridiculamente violenta posible
        public IAnimal? GetAnimalAt(int index)
        {
            if (index >= 0 && index <= _animals.Count)
                return _animals[index];

            return null;
        }

        public void DeleteAnimalAt(int index)
        {
            IAnimal? a = GetAnimalAt(index);

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

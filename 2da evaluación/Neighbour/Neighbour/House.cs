using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour
{
    internal class House
    {
       private List<Persona> people = new List<Persona>();

        private int _floor;
        private string _letter;


        // Javi: Nombre horroroso
        public int GetPeopleQuantity
        {
            get => people.Count;
        }

        public int Floor
        {
            get => _floor;

            set
            {
                _floor= value;

                if(value == null)
                {
                    _floor= 1;
                }
            }
        }

        public string Letter
        {
            get => _letter;

            set
            {
                _letter= value;

                if (value == null)
                    _letter = "A";
            }
        }

        public void AddPerson(Persona person)
        {
            for (int i=0; i<people.Count; i++) 
            {
                if (people[i].Telephone == person.Telephone || people[i].Gmail == person.Gmail)
                {
                    return;
                }
            }
            people.Add(person);
        }

        // Javi: Como que remove!??!?! esta funcion borra!??!?!?
        public int RemovePersonByName(string inputName) 
        {
            for (int i = 0; i < people.Count; i++) 
            {
                if (people[i].Name== inputName)
                    return i;
                
            }
            return -1;
        }

        // Javi: Se puede optimizar mucho
        public void RemovePersonByGmail(string inputGmail)
        {
            for(int i=0; i<people.Count;i++) 
            {
                if (people[i].Gmail == inputGmail)
                    people.RemoveAt(i);
            }
        }

        public bool ContainsPersonName(string inputName)
        {
            for(int i=0; i<people.Count;i++) 
            {
                if (people[i].Name == inputName) 
                    return true;
            }
            return false;
        }

        public bool ContainsPersonMail(string inputMail)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Gmail == inputMail)
                    return true;
            }
            return false;
        }

        public bool ContainsPersonPhone(string inputPhone)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Telephone == inputPhone)
                    return true;
            }
            return false;

        }

        public void Clear()
        {
            people.Clear();
        }

    }
}

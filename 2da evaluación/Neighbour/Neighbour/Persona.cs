using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Neighbour
{
    public enum gender
    {
        MAN,
        WOMAN,
        OTHER
    }
    internal class Persona
    {
        private string _name;
        private int _age;
        private gender _gender;
       

        private string _gmail;
        private string _telephone;

        public string Name
        {
            get => _name;
        }
        public int Age
        {
            get => _age;
        }

        public gender Gender
        {
            get => _gender;
        }

        public string Gmail
        {
            get => _gmail;

            set 
            {
                _gmail = value;
                if (value == null || !CheckMail.CheckIfMail(value)) 
                {

                    _gmail = "neighbour@gmail.com";

                }
            }
        }

        public string Telephone
        {
            get => _telephone;

            set 
            {
                _telephone = value;
                if (value.Length < 9 || value.Length > 9 || _telephone == null)
                {
                    _telephone = "111111111";
                }
            }
        }

        public Persona() { }

        public Persona(int age, string name) 
        {
            _age = age;
            _name = name;
        }

        public string ToString()
        {
            return JsonSerializer.Serialize(_age + ", " + _name + ", " + _gender + ", " + _gmail + ", " + _telephone);
        }

        public Persona Clone()
        {
            return new Persona()
            {
                _age = this._age,
                _name = this._name,
                _gender = this._gender,
                _gmail = this._gmail,
                _telephone = this._telephone

            };
        }


    }
}

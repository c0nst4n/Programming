using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace StudentListChunga
{
    internal class Student
    {
        private int _age;
        private string _name;
        private string _description;

        public int Age
        {
            get => _age;
            set => _age = value;
        }
        public string Name
        {
            get => _name;

            set => _name = value;
        }
        public string Description
        {
            get => _description;

            set => _description = value;
        }

        public Student() { }  
        public Student(int age, string name, string description) 
        {
            _age = age;
            _name = name;
            _description = description;
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}

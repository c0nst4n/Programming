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

        public int Age => _age;
        public string Name => _name;
        public string Description => _description;

        public string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}

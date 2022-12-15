using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModel
{
    public class Model
    {
        public static string countTo(int number)
        {
            string result = "";

            for(int i = 0; i < number; i++)
            {
                result += i + ", ";
            }
            return result;
        }
    }
}

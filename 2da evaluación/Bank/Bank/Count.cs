using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    // Javi: account
    internal class Count
    {
        // Javi: El orden es: atributos, properties, constructores y funciones
        private string _account_code;
        private string _title;
        private double _quantity;

        public string GetName() { return _title; }
        public string SetName(string name) //Duda[6]
        {
            // Javi: Los setters, en esencia no devuelven nada
           _title = name;
            return _title;
        }

        public string Name
        {
            get { return _title; }

            set { _title = value; }
        }

        public double GetQuantity()
        {
            return _quantity;
        }
        public double Quantity
        {
            get { return _quantity; }
        }
        public string AccountCode
        {
            get { return _account_code; }
        }

        public double IngressQuantity(double quantity)
        {
            if (quantity < 0)
            {
                return 0;
            }

            _quantity += quantity;

            return _quantity;
        }

        public string ToString()
        {
            string result = _account_code + _title + _quantity;
            return result;
        }
        public double RemoveQuantity(double quantity) //duda [12]
        {
            double result = _quantity - quantity;
            if (result < 0)
                return 0;
            return result;
        }


        public Count()
        {

        }

        public Count(string account_code, string title, double quantity) 
        {
            this._account_code = account_code;
            this._title = title;
            this._quantity = quantity;

        }
    }
}

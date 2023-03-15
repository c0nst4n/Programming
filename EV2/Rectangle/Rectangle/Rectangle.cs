using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Rectangle
    {
        private double _x, _y, _height, _width;

        public Rectangle()
        {

        }

        public Rectangle(double width, double height, double x, double y)
        {
            _width = width;
            _height = height;
           _x = x;
            _y = y;

        }

        public double GetDiagonal()
        {
            double width2 = _width * _width;
            double height2 = _height * _height;
            return Math.Sqrt(width2 + height2);
        }

        public double GetArea()
        {
           return _width *= _height;
        }

        public double GetPerimeter()
        {
            return 2 * (_height + _width);

        }

        // Javi: Función incorrecta
        public bool  IntersectsWith(Rectangle other)
        {
            // Javi: Nombre horroroso
            bool position = true;
            bool size = true;

            if (other._x != _x)
                position = false;
            if (other._y != _y)
                position = false;

            if (other._width != _width)
                size = false;
            if (other._height != _height)
                size = false;

            if (position == false || size == false)
                return false;
            return true;
        }

    }
}

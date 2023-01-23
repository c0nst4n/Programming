using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Segment
{
    public class Segment2D
    {
        private Point2D _pointA;
        private Point2D _pointB;

        Segment2D() 
        {
            
        }

       public Segment2D(Point2D A, Point2D B) 
        {
            _pointA = A;
            _pointB = B;
        
        }

        void moveRight(double quantity)
        {
            _pointA.x += quantity;
            _pointB.x += quantity;
        }

         void moveLeft(double quantity)
        {
            _pointA.x -= quantity;
            _pointB.x -= quantity;
        }

         void moveUp(double quantity)
        {
            _pointA.y += quantity;
            _pointB.y += quantity;
        }
         void moveDown(double quantity)
        {
            _pointA.y -= quantity;
            _pointB.y -= quantity;
        }

        public override string ToString()
        {
          return JsonSerialize
        }

        double GetDistance()
        {
            double Xresult = _pointB.x - _pointA.x;
            double Yresult = _pointB.y - _pointA.y;
            double X2 = Xresult * Xresult;
            double Y2 = Yresult * Yresult;
            return Math.Sqrt(X2 + Y2);

        }

         Point2D GetMedPoint()
        {
            double X = (_pointA.x + _pointB.x) / 2;
            double Y = (_pointA.y + _pointB.y) / 2;

            Point2D pointX = new Point2D(X, Y);

            return pointX;
        }

        void ChangeY()
        {
            double swap;
            swap = _pointA.y;
            _pointA.y = _pointB.y;
            _pointB.y = swap;

        }

        double GetU (Segment2D other) 
        {
            double x4 = other._pointB.x;
            double x3 = other._pointA.x;
            double x1 = _pointA.x;
            double x2 = _pointB.x;
            double y1 = _pointA.y;
            double y2 = _pointB.y;
            double y3 = other._pointA.y;
            double y4 = other._pointB.y;
            double dividing = (x4 - x3) * (y1 - y3) - (y4 - y3) * (x1 - x3);
            double divisor = (y4 - y3) * (x2 - x1) - (x4 - x3) * (y2 - y1);
            return dividing / divisor;
        }


        public Point2D CheckInteresction(Segment2D other) 
        { 
            double U = GetU(other);

            double X = _pointA.x + U * (_pointB.x - _pointA.x);
            double Y = _pointA.y + U * (_pointB.y - _pointA.y);

            Point2D intersection = new Point2D(X, Y);
            return intersection;
        
        }

    }
}

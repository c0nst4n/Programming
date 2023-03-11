using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Cuadratica
{
    internal class Equation
    {

        private double _a;
        private double _b;
        private double _c;

        public Equation()
        {

        }

        public Equation(double a, double b, double c)
        {
            this._a = a;
            this._b = b;
            this._c = c;

        }

        public (double, double) GetRoot(double a, double b, double c)
        {
            double proof = GetProof(a, b, c);
            if (proof < 0)
                return (double.NaN, double.NaN);

            double rootcontent = (b * b) - 4 * a * c;
            double posresult = -b + Math.Sqrt(rootcontent) / (2 * a);
            double negresult = -b - Math.Sqrt(rootcontent) / (2 * a);

            return (posresult, negresult);
        }

        public double GetProof(double a, double b, double c)
        {
            return (b * b) - 4 * a * c;
        }

        public  bool HasRoots(double a, double b, double c)
        {
            double proof = GetProof(a, b, c);
            return proof <= 0;
        }

        public bool HasRoot(double a, double b, double c)
        {
            double proof = GetProof(a, b, c);
            return proof == 0;
        }

    }
}

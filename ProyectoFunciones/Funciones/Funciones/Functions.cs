using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    internal class Functions
    {

        /*(obligatorio) Realiza una función que se le pase dos jugadas de “Piedra, papel, tijera, lagarto o
        Spock” y devuelva quién gana de los dos. Si gana el primer jugador, devuelve un -1, si gana el
        segundo devuelve un 1, si quedan empates, un 0. Se tiene que usar un enum.
         */
       public enum type
        {
            ROCK,
            PAPER,
            SCISOR,
            SPOCK,
            LIZARD
        }
        public static int Spock(type player1, type player2)
        {
            if (player1 == player2) //empate
                return 0;
            // En las que gana el jugador 1
            if (player1 == type.ROCK && (player2 == type.LIZARD || player2 == type.SCISOR))
                return -1;
            if (player1 == type.PAPER && (player2 == type.SPOCK || player2 == type.ROCK))
                return -1;
            if (player1 == type.SCISOR && (player2 == type.LIZARD || player2 == type.PAPER))
                return -1;
            if (player1 == type.LIZARD && (player2 == type.PAPER || player2 == type.SPOCK))
                return -1;
            if (player1 == type.SPOCK && (player2 == type.SCISOR || player2 == type.ROCK))
                return -1;

            //En las que gana el jugador 2
            return 1;
        }

        /*
         * (obligatorio) Desarrolla una función que devuelva el
         * resultado de una ecuación de segundo grado.
         */

        public static (double, double) sgequation(double a, double b, double c)
        {
            if (a == 0)
                return (double.NaN,double.NaN);

            double root = (b * b) - 4 * a * c;

            if (root < 0)
                return (double.NaN, double.NaN);

            double divisor = 2 * a;
            double posdivedend = -b + Math.Sqrt(root);
            double negdivedend = -b - Math.Sqrt(root);
            return (posdivedend/divisor, negdivedend/divisor);
        }

        /*
         * (obligatorio) Escriba un programa que devuelva un string con
         * todas las combinaciones posibles
           al momento de lanzar tres dados de 6 
           caras. (1, 1, 1) (1, 1, 2) (1, 1, 3), …
         */

        public static string giveDice()
        {
            string result = "";
            for(int i = 1; i < 7; i++)
            {
                for(int j=1; j < 7; j++)
                {

                    for( int k=1; k < 7; k++)
                    {
                        result += "("+ i + ", " + j +", " + k + ")" + ", ";
                    }
                }
            }
            return result;
        }

        /*(obligatorio) Es posible expresar 100 como la suma de tres cubos, 
         * cada uno de los cuales puede
        ser negativo o positivo. 
        Sólo se conocen tres maneras de hacerlo. 
        Una de ellas es la siguiente:
       1870 ^3 − 1797 ^3 − 903 ^3 = 100
         */

        public static string oneHundredComb()
        {
            //Les he puesto 101 de máximo porque si no mi ordenador no puede, solo tengo 8 de ram y con 10000 no puede
           string note = "";
            
            for(double a = -100; a != 101; a++)
            {
                for (double b = -100; b != 101; b++)
                {
                    for(double c = -100; c != 101; c++)
                    {
                        if ((a * a * a) + (b * b * b) + (c * c * c) == 100)
                        {
                            note +="(" + a + "^3" + " + " + b + "^3" + "+" + c + "^3" + " = 100" + ")";
                        }
                    }
                }
            }
            return note;

            
        }
    }
}

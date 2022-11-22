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
            double divisor = 2 * a;
            double posdivedend = -b + Math.Sqrt(root);
            double negdivedend = -b - Math.Sqrt(root);
            return (posdivedend/divisor, negdivedend/divisor);
        }
    }
}

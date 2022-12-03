using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    internal class Functions
    {
        /*Escribir una función que calcule el área de un círculo y otra que calcule el volumen de un cilindro
          usando la primera función.
         */

        public static double getCircleArea(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double getCilinderArea(double radius, double heighth)
        {
            double area = getCircleArea(radius);
            return area * heighth;

        }
        

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
        /*Desarrolla una función que devuelva el 
         * resultado de una ecuación de primer grado.
         */
            
        public static int fgequation(int a, int b) //Hecho con esta estructura en mente de: ax+ b == 0
        {
            if (a < 1)
                return 0;
             
            return b - 0 / a;


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

        /*Los tres lados a, b y c de un triángulo deben satisfacer la desigualdad triangular: cada uno de los
        lados no puede ser más largo que la suma de los otros dos. Escribe un programa que reciba como
        entrada los tres lados de un triángulo (son reales), e indique: si acaso el triángulo es inválido; y si
        no lo es, qué tipo de triángulo es (un enum).
         */
        public enum triangletype
        {
            EQUILATERAL,
            ISOSCELES,
            SCALENE,
            INVALID

        }

        public static triangletype GetTriangletype(double a, double b, double c)
        {

            if ((a > b + c) || (b > c + a) || (c > b + a))
                return triangletype.INVALID;
            if ((a < 1) ||(b < 1) ||(c < 1))
                return triangletype.INVALID;

         
            if ((a == b) && (a != c))
                return triangletype.ISOSCELES;
            if ((a != b) && (b == c))
                return triangletype.ISOSCELES;
            if ((a == c) && (a != b))
                return triangletype.ISOSCELES;


            if ((a != b) && (a != c) && (b != c))
                return triangletype.SCALENE;

            return triangletype.EQUILATERAL;

            
        }

        /*Escribir una función que calcule el máximo común divisor de dos números.
         */



        /*Escribir una función que calcule el máximo común divisor de dos números.
         */
        public static double GetMinor(double a, double b)
        {
            if (a < b)
                return a;
            return b;
        }

        public static double MCD(double a, double b)
        {
            for(double i = GetMinor(a, b); i > 0; i--)
            {
                if ((a % i == 0) && (b % i == 0))
                    return i;
            }

            return 0;
        }

        /*Escribir una función que calcule el mínimo común múltiplo de dos números
         */

        public static double MCM(double a, double b)
        {
            double multiple = 0;
            for(double i = 2; multiple == 0; i++)
            {
                if ((a%i == 0) && (b%i == 0))
                {
                    multiple = i;
                }

            }

            return multiple;
            
                
        }

        /*Escriba un programa que devuelva un string 
         * con los números naturales menores o 
         * iguales que un
        número n determinado y 
        que no sean múltiplos ni de 3 ni de 7.
         */

        public static string GetNoMultiplesOf3or7(int limit) //¿Que nombre le pondrías a esto siquiera?
        {
            string list = "";

            for (int i = 1; i <= limit; i++) //Empezamos por 1 porque no puede dividir entre 0 para preguntar si es multiplo de 3 o 7
            {
                if ((3%i != 0) && (7%i != 0))
                {
                    list += i + ", ";
                }
            }

            return list;
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
            
            for(double a = -100; a <= 101; a++)
            {
                for (double b = -100; b <= 101; b++)
                {
                    for(double c = -100; c <= 101; c++)
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

        /*(obligatorio) Multiplicación rusa. El método de multiplicación rusa consiste en multiplicar
        sucesivamente por 2 el multiplicando y dividir por 2 el multiplicador hasta que el multiplicador tome
        el valor 1. Luego, se suman todos los multiplicandos correspondientes a los multiplicadores
        impares.
        Dicha suma es el producto de los dos números. La siguiente tabla muestra el cálculo realizado
        para multiplicar 37 por 12, cuyo resultado final es 12 + 48 + 384 = 444.
         */

        public static int russianMult(int multiplied, int multiplier)
        {
            if ((multiplied == 0) ||(multiplier <= 0)) //Si el número fuera negativo, ni entraría
                return 0;

            int result = 0;
            for (int i = multiplied; multiplied > 0; multiplied /= 2, multiplier *= 2)
            {
                if (multiplied % 2 != 0)
                    result += multiplier;
            }

            return result;

        }

        /*(obligatorio) Crea una función que quite los espacios por delante y por detrás de un string. Se
        considera un espacio: un espacio, un tabulador, un salto de línea y retorno de carro. La función
        recibe un string y dos booleanos.


        Vamos a necesitar de funciones auxiliares para tener esto organizado, así que dejaré comentarios para
        describir lo que hacen
         */

        
        public static bool checkSpace (char c) //Pregunta si hay un espacio de cualquier tipo o un "@"
        {
            if ((c == '\r') || (c == '\t') || (c == ' ') || (c == '\n') || (c == '@'))
                return true;
            return false;
        }

        /*Usando la función anterior, preguntamos si cada letra de un string es un espacio o una arroba
         */
        public static int CheckChars (string phrase) 
        {
            for (int i = 0; i < phrase.Length; i++)
            {
                if (checkSpace(phrase[i]) == false)
                    return i;
            }
            return -1;
        }

        /* Igual pero en orden contrario, porque si hay un espacio 
         * entre palabras eso si que lo queremos dejar
         */
        public static int CheckCharsBackw (string phrase)
        {
            for (int i = phrase.Length - 1; i < phrase.Length; i--)
            {
                if (checkSpace(phrase[i]) == false)
                    return i;
            }
            return -1;
        }
        //Y esta sería la función final que las usa todas
        public static string deleteSpaces(string phrase, bool before, bool after)
        {
            int start = CheckChars(phrase);
            int end = CheckCharsBackw(phrase);

            if ((before) && (after == false))
                return phrase.Substring(start, phrase.Length - start);
            else if ((before) && (after))
                return phrase.Substring(start, (end - start) + 1);
            else if ((before == false) && (after == false))
                return phrase;
            else 
                return phrase.Substring(0, end + 1);

            return "No se ha detectado ningún string";

        }

        /*(obligatorio) Crea un programa que calcula una aproximación de PI mediante la expresión:
        pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 (...) A esta función se le pasará un entero con el
        número de iteraciones a realizar. Por ejemplo, si se le pasa un 4, el programa calculará:
        p = 4 * (1/1 - 1/3 + 1/5 - 1/7)
         */

        public static double PIAprox(int iterations)
        {
           

            double p = 4;
            double result = 0;
            int positive = 1;
            for(int i = 1; i < iterations; i++)
            {
                if (positive > 0)
                    result += 1 / i;
                else
                    result -= 1 / i;
                positive *= -1;
            }

            return p * result;
        }


        /*Escribir una función que reciba un número entero positivo y 
         * devuelva su factorial. Hay que hacer
        esta función de 2 formas, una iterativa y otra recursiva.
         */

        //iterativa

        public static int IterativeFactorial(int number)
        {
            if (number <= 0)
                return 0;

            int result = 1;

            for(int i = 1; i <= number; i++)
            {
                result *= i;

            }

            return result;
        }
        
        //Recursiva
       /* public static int RecursiveFactorial(int number)
        {
            if (number <= 0)
                return 0;
            int result = 1;
            int summ = 1;
            result *= summ;
            summ += 1;
            while (summ < number)
            {
                RecursiveFactorial(number);
                
            }

            return result;

        }
        */

        /*Escribir una función que reciba un número entero positivo y devuelva su sumatorio. 
         * Hay que hacer
        esta función de 2 formas, una iterativa y otra recursiva.
         */

        //iterativa
        public static int IterativeSummatory(int number)
        {
            if (number < 0)
                return 0;

            int result = 0;

            for (int i=0; i <= number; i++)
            {
                result += i;
            }

            return result;

        }

        /* 
        (obligatorio) Según Sheldon, el mejor número es el 73.
        73 es el 21er número primo. Su espejo, 37, es el 12mo número primo. 21 es el producto de
        multiplicar 7 por 3. En binario, 73 es un palíndromo: 1001001.
        Escriba programas que le permitan responder las siguientes preguntas:
        ¿Existen otros valores p que sean el n-ésimo primo, tales que espejo(p) es el espejo(n)-ésimo
         primo?
         ¿Existen otros valores p que sean el n-ésimo primo, tales que n es el producto de los dígitos de p?
        ¿Cuáles son los primeros diez números primos cuya representación binaria es un palíndromo?

        */

        public static bool isPrime(int number) //Comprobar si un número es primo
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;

            }
            return true;

        }

        public static int PrimeOrder(int number) //Saber el orden del número primo
        {
            int count = 0;
            if (isPrime(number))
                for (int i = 2; count < number; i++)
                {
                    if (isPrime(i))
                        count++;
                    if (i == number)
                        return count;
                }
            return -1;
        }

        public static string ToBinary(int number) //Pasas un número a binario
        {
            string result = "";
            while (number > 0)
            {
                if (number % 2 == 0)
                    result = result + "1";
                if (number % 2 == 1)
                    result = result + "0";
                number /= 2;

            }

            return result;
        }

        public static string RevertString(string word) //Pone un string al revés para poder comprobar palindromos luego
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += word[i];
            }

            return result;
        }

        public static bool CheckPalindrome(int number)//Miramos si el binario de un número es palindromo
        {
            string binary = ToBinary(number);
            string reverse = RevertString(binary);

            if (binary == reverse)
            {
                return true;
            }

            return false;
        }
        //¿Cuáles son los primeros diez números primos cuya representación binaria es un palíndromo?
        public static string PrimePalindromes()
        {
            string result = "";
            int counter = 0;
            for(int i = 3; counter <= 10; i++)
            {
                if ((CheckPalindrome(i) && (isPrime(i))))
                {
                    result += i + ", ";
                    counter ++;
                }
            }

            return result;
        }

    }
}

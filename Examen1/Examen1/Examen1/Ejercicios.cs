using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Ejercicios
    {
        //Ejercicio 1
        // Nota: 1
        public static int Exercise1(int a, int b)
        {
            return (a + 1) / b;
        }

        //Ejercicio 2
        // Nota: 4
        public static int Exercise2(int a, int b, int c, int d, int e, int x)
        {
            int xfour = x * x * x * x;
            int xthree = x * x * x;
            int xtwoo = x * x;

            return a * xfour + b * xthree + c * xtwoo + d * x + e;

        }

        //Ejercicio 3
        // Nota: 4
        public static int GetMinor(int a, int b)
        {
            if (a < b)
                return a;
            return b;
        }
        
        public static int Exercise3 (int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)
        {
            int GM = GetMinor(GetMinor(GetMinor(a, b), GetMinor(c, d)), GetMinor(GetMinor(e, f), GetMinor(g, h)));

            return GetMinor(GM, GetMinor(i, j));
        }

        //Ejercicio 4
        public static int GetMajor(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }
        // Nota: 0
        public static int Exercise4(int a, int b, int c)
        {
            int distone = a - b;
            int distwo = a - c;
            return GetMajor(distone, distwo);
        }
        
        //Ejercicio 9
        // Nota: 3
        public enum machinestate
        {
            PREPARADO,
            PROCESANDO,
            EJECUTANDO,
            TERMINADO
        }

       /* public static machinestate (bool condition, machinestate state)       Este no funciona por varios motivos, por eso esta comentada
        {
            if (condition == false)
                return state;
            if (condition == true)
            {
                switch (state)
                {
                    case PREPARADO:
                        return machinestate.PROCESANDO;
                        break;
                    case PROCESANDO:
                        return machinestate.EJECUTANDO
                        break;
                    case EJECUTANDO:
                        return machinestate.TERMINADO
                        break;
                    DEFAULT:
                    return machinestate.PREPARADO
                    break;

                }
                return state;
            }
        }
      */

        //Ejercicio 10
        // Nota: 4
        public static int DivisorSummatory(int number)
        {
            int result = 0;

            for(int i=1; i < number; i++)
            {
                if (number % i == 0)
                    result += i;
            }
            return result;
        }

        //Ejercicio 7
        // Nota: 0
        public static bool CheckVowel(char c)
        {
            if ((c == 'A') || (c == 'a') || (c == 'e') || (c == 'E') || (c == 'i') || (c == 'I') || (c == 'O') ||
                (c == 'U') || (c == 'u'))
            {
                return true;
            }

            return false;
        }

        
        public static (int, int) GetVowel(string word)
        {
            char c = ' ';
            char b = ' ';

            for(int i = 0; i < word.Length; i++)
            {
                c = word[i];
                
                for(int j = word.Length -1; j != 0; j--)
                {
                    b = word[j];
                    if ((CheckVowel(c) == true) && (CheckVowel(b) == true))
                    {
                        return (i, j);
                    }
                }
            }

            return (0, 0);
        }
        
    }
}

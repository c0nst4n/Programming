using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercises
{
    internal class Exercises
    {
        public static bool IsEven(int a)
        {
            return a % 2 == 0;
        }

        public static bool IsCousin(int a)
        {

            for (int i = 2; i < a; i++)
            {
                if ((a % i) == 0)
                    return false;

            }

            return true;
        }

        public static double GetAreaCir(double rad)
        {

            return Math.PI * (rad * rad);
        }

        public static double GetAreaRec(double a, double b)
        {
            return a * b;
        }

        public static double GetDistance(double ax, double bx, double ay, double by)
        {
            double X = ax - bx;
            double Y = ay - by;

            double root = X * X + Y * Y;
            return Math.Sqrt(root);
        }

        public static string GetCousin(int number)
        {
            string result = "";
            for (int i = 1; i <= number; i++)
            {
                if (IsCousin(i))
                {
                    result = result + i + ",";
                }
            }

            return result;
        }

        public static string GetFibonacci(double number)
        {
            if (number == 0)
                return "NaN";
            string result = "0,1,";
            
            int r = 0;
            int r2 = 1;
            int multplr = 1;
            for (int i = 0; r < number && r2 < number; i ++)
            {
                if (IsEven(i))
                {
                    r = r + r2;
                    if (r < number)
                    {
                        result += r + ",";
                    }
                    
                } 

                else
                {
                    r2 = r + r2;
                    if (r2 < number)
                    {
                        result += r2 + ",";
                    }
                    
                }
                 

                multplr *= -1;
            }

            return result;
        }

        public static double GetDistanceVec(Vector3 a, Vector3 b)
        {
            double X = a.x - b.x;
            double Y = a.y - b.y;
            double Z = a.z - b.z;

            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public static string GetLines(string word)
        {
            int length = word.Length;
            char c = word[0];
            string result = "" + c;
            for (int i = 1; i < length; i++)
            {
                c = word[i];
                result += '-' + c;
            }
            return result;
        }

        public static bool GetCharOrder(char character, char min, char max)
        {
            return character >= min && character <= max;
        }

        /*public static bool IsGmail(string subject)
        {

            int length = subject.Length;
            bool at = false;
            bool dot = false;
            for (int i = 0; i < length; i++)
            {

                char c = subject[i];
                if (c =='@')
                {
                    at = true;
                }

                if (c == '.')
                {
                    dot = true;
                }

            }

            return at && dot;



        }*/
        public static int GetNumberOf(string text, char c)
        {
          int counter = 0;
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == c)
                    counter++;
            }
            return counter;

            //Si word es algo parecido a length
            // Y puede hacer word[i]
            /*foreach (char ch in text)
            {
                if (c == '@')
                    count++;
            }*/
        }

       

        public static bool CheckCharacters(string text)
        {
            for(int i = 0; i < text.Length; i++)
            {
                if (!GetCharOrder(text[i],'a','z') &&
                    !GetCharOrder(text[i], '0', '9') &&
                    !GetCharOrder(text[i], 'A', 'Z') &&
                    text[i] != '@' && text[i] != '.' && text[i] != '_')
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckStartOrEnd(string text, char c)
        {
            return text[0] == c || text[text.Length - 1] == c;
        }

        public static bool CheckDotAfterAr(string text)
        {
            bool at = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '@')
                    at = true;
                if (at && text[i] == '.')
                    return true;
            }
            return false;
        }

        public static bool CheckSize(string text, int quantity)
        {
            return text.Length >= quantity;
        }

        public static bool CheckSyntax(string text)
        {
            return text.Contains("..") ||
                text.Contains("@.") ||
                text.Contains(".@");
          
        }

        public static bool CheckIfMail(string mail)
        {
            if (GetNumberOf(mail, '@') != 1)
                return false;
            if (CheckSyntax(mail))
                return false;
            if (CheckCharacters(mail))
                return false;         
            if (CheckStartOrEnd(mail, '@') || CheckStartOrEnd(mail, '.'))
                return false;
            if (!CheckDotAfterAr(mail))
                return false;
            if (CheckSize(mail, 80))
                return false;

            return true;
        }

        public static double GetVecModule(Vector3 a)
        {
            double x2 = a.x * a.x;
            double y2 = a.y * a.y;
            double z2 = a.z * a.z;

            return Math.Sqrt(x2 + y2 + z2);
            
        }

        //Función que devuelva el resultado del productorio de un número (cómo sumatorio pero de multiplicación)
        public static int GenerateProductory(int n)
        {
            int j = 1;
            for(int i = 1; i <= n; i++)
            {
                j *= i;
            }
            return j;
        }

        public static int GetMCD(int n, int m)
        {
          int max = 0;
            if (m <= 0 || n <= 0)
            {
                return 0;
            }
            for(int i = 2; i <= n && i <= m; i++)
            {
                if (n % i == 0 && m % i == 0)
                {
                   max = i;
                }
            }

            return max;

        }

        public static double saturate(double value, double min, double max)
        {
           if (value > min)
            {
                return min;
            }

            if (value > max)
            {
                return max;
            }

            else return value;
        }

        public static double circular(double value, double min, double max)
        {
            double dis = max - min;

            while (value < min || value > max)
            {
                if (value >= max)
                
                    value -= dis;
                
                else
                    value += dis;
            }

            return value;
        }

        public static double lerp(double min, double max, double u)
        {
            double dis = max - min;

            return min + (dis * u);

        }

        public static double ulerp(double min, double max, double u)
        {
            double dist = max - min;
            return (u - min) / dist;
        }

        public static (double, double) MinAndMax(double a, double b)
        {
            if (a > b)
                return (a, b);
            return (b, a);

        }

        public static double CheckNum(double a, double b)
        {
            if (a > b)
                return -1;
            if (a < b)
                return 1;
            return 0;
        }

        public static string ToBinary (int a)
        {
            string binary = ""; 
            while (a > 0)
            {
                int rest = a % 2;
                binary = rest + binary;
                a /= 2;
            }

            return binary;
        }

        public static char ToCap (char letter)
        {
           
            if ('a' <= letter && letter <='z')
            {
                return (char)(letter - 'a' + 'A');

            }
            return letter;
        }

        public static double GetAvg(double min, double max)
        {

            return (min + max) / 2;
        }

        public static string GetMorse (string palabra)
        {
            string result = "";
            foreach (char c in palabra)
            {   char upper = ToCap (c);
                switch(upper)
                {
                    case 'a':
                        result += ".-";
                        break;
                    case 'b':
                        result += "-...";
                        break;
                    default:
                        result += "*";
                        break;
                }         
            }
            return result;
        }

        public static void GetMultTab(int number)
        {
            string result = "";
            for (int i = 1; i == 11; i++)
            {
                
                Console.WriteLine(i + "x" + number + "=" + (i*number));
            }

            
        }

        public static string FirstNumbs(int number)
        {

            string result = "";
            int a = -1;
            for(int i = 0; i < number; i++)
            {
                result += ", " + a;
                a *= -2;
            }

            return result;
        }

        public static int GetEvensBeet(int min, int max)
        {
            int result = 0;

            for (int i = min; i < max; i++)
            {
                if (IsCousin (i))
                {
                    result += i;
                }
            }

            return result;
        }

        public static string GetMult (int number)
        {
            string result = "";
            int divider = 2;

          while(number > 1)
            {
                if (number % divider == 0)
                {
                    result += divider + "*";
                    number /= divider;
                }
                else
                    divider++;
            }
            return result;

        }

        public static string Collatz(int number)
        {
            string result = "";

            while ( number > 1)
            {
                if (IsEven(number))
                    number /= 2;
                else
                    number = number * 3 + 1;

                result += number + ",";            
            }

            return result;
        }

        public static (int num, int den) SimplifyFraction (int nume, int deno)
        { 
            int mcm = GetMCD(nume, deno);
           
            deno /= mcm;
            nume /= mcm;
            return (nume, deno);
        }

    }


}

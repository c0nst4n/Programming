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
    }

}

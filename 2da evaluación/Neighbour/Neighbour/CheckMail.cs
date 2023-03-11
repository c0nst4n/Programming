using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour
{
    public class CheckMail
    {

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
            for (int i = 0; i < text.Length; i++)
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
            for (int i = 0; i < text.Length; i++)
            {
                if (!GetCharOrder(text[i], 'a', 'z') &&
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

    }
}

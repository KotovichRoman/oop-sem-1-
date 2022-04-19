using System;

namespace lab9
{
    public static class UserString
    {
        public static string DeletePunctuationMark(string str)
        {
            str = str.Replace(",", " ");
            str = str.Replace(".", " ");
            return str;
        }

        public static string AddSymbols(string str)
        {
            string symbols = Console.ReadLine();
            str += symbols;
            return str;
        }

        public static string ToUpper(string str)
        {
            str = str.ToUpper();
            return str;
        }

        public static string ToLower(string str)
        {
            str = str.ToLower();
            return str;
        }

        public static string DeleteExtraSpace(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' && str[i + 1] == ' ')
                {
                    str = str.Remove(i);
                }
            }

            return str;
        }
    }
}
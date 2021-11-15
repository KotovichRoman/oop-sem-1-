using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public static class StatisticOperation
    {
        public static int? Sum(Set set)
        {
            int? summa = 0;

            foreach (int element in set.Array)
            {
                summa += set.Array[element];
            }

            return summa;
        }

        public static int? MaxMinusMin(Set set)
        {
            int? maxElement = set.Array[0];
            int? minElement = set.Array[0];

            foreach (int element in set.Array)
            {
                if (maxElement < set.Array[element])
                {
                    maxElement = set.Array[element];
                }

                if (minElement > set.Array[element])
                {
                    minElement = set.Array[element];
                }
            }

            return maxElement - minElement;
        }

        public static int? CountElement(Set set)
        {
            return set.Array.Length;
        }
    }

    public static class StringExtension
    {
        public static bool CharCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }

            if (counter > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

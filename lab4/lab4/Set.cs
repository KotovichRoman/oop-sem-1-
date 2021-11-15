using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public class Set
    {
        public int?[] Array { get; set; }

        public Set(int?[] array)
        {
            this.Array = array;
        }

        public static Set operator >>(Set set1, int numberOfElement) //удаление элемента
        {
            Set set2 = new Set(new int?[] { });
            int i = 0;

            foreach (int element in set1.Array)
            {
                if (element != numberOfElement)
                {
                    set2.Array[i] = set1.Array[element];
                    i++;
                }
            }

            return set2;
        }

        public static Set operator <<(Set set1, int element)
        {
            set1.Array[set1.Array.Length + 1] = element;
            return set1;
        }

        public static bool operator !=(Set set1, Set set2) //проверка множеств на неравенство
        {
            if (set1 != set2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Set set1, Set set2)
        {
            if (set1 == set2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Set operator %(Set set1, Set set2) //пересечение
        {
            Set setWithGeneralElements = new Set(new int?[] { });
            return setWithGeneralElements;
        }

        //методы
        public static int? MinElement(Set set)
        {
            int? minElement = set.Array[0];
            foreach (int element in set.Array)
            {
                if (set.Array[element] < minElement)
                {
                    minElement = set.Array[element];
                }
            }

            return minElement;
        }

        public static int?[] sortSet(Set set)
        {
            int?[] numbers = new int?[] { };
            int? elementNumber;

            for (int i = 0; i < set.Array.Length; i++)
            {
                for (int j = i + 1; i < set.Array.Length; j++)
                {
                    if (set.Array[i] > set.Array[j])
                    {
                        elementNumber = set.Array[i];
                        set.Array[i] = set.Array[j];
                        set.Array[j] = elementNumber;
                    }
                }
            }

            return numbers;
        }

        private Owner owner1 = new Owner(1, "Name1", "OrganizationName1"); //вложенный объект

        private class Date //вложенный класс
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            private Date(int day, int month, int year)
            {
                this.Day = day;
                this.Month = month;
                this.Year = year;
            }

            private Date date1 = new Date(20, 12, 2002);
        }
    }

}

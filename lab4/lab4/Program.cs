using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Xml.Linq;

namespace lab4
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OrganizationName { get; set; }

        public Owner(int id, string name, string organizationName)
        {
            this.Id = id;
            this.Name = name;
            this.OrganizationName = organizationName;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Set mySet1 = new Set(new int?[] { 1, 2, 3 });
            Set mySet2 = new Set(new int?[] { 1, 2, 3, 4, 5 });
            Set mySet3 = new Set(new int?[] { });
            Set mySet4 = new Set(new int?[] { 2, 1, 4, 3, 5 });

            int deleteElement = Convert.ToInt32(Console.ReadLine());
            mySet1 = mySet1 >> deleteElement;
            Console.WriteLine(mySet1);

            int?[] subset = new int?[] { 2, 3 };
            Console.WriteLine(mySet2 > subset);

            Console.WriteLine(mySet1 != mySet2);

            int addElement = Convert.ToInt32(Console.ReadLine());
            mySet1 = mySet1 << addElement;
            Console.WriteLine(mySet1);

            mySet3 = mySet1 % mySet2;
            Console.WriteLine(mySet3);

            Console.WriteLine(Set.MinElement(mySet3));

            Console.WriteLine(Set.sortSet(mySet4));

            string str = "1234";
            char c = '1';
            bool i = StatisticOperation.CharBool(str, c);
        }
    }
}
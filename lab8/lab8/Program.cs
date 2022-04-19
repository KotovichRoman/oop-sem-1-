using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Xml.Linq;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CollectionType<Technic> collection = new CollectionType<Technic>();

                Technic[] technics =
                {
                    new Technic("Computer"),
                    new Technic("Laptop"),
                    new Technic("Tablet"),
                    new Technic("Scanner"),
                    new Technic("Printer")
                };

                foreach (var elem in technics)
                {
                    collection.Add(elem);
                }

                collection.View();
                Console.WriteLine();

                collection.Remove(technics[2]);
                collection.View();
                Console.WriteLine();

                collection.WriteFile();
                collection.ReadFile();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.WriteLine("\nFinally");
            }
        }
    }
}
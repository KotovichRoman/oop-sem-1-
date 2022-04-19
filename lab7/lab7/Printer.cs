using System;

namespace lab7
{
    public class Printer : APrinter
    {
        public string AmPrinting;
    }
    public abstract class APrinter
    {
        public void IamPrinting(Technic someObj)
        {
            Console.WriteLine($"Тип этого обьекта: " + someObj.GetType());
            Console.WriteLine(someObj.ToString());
        }
    }
}
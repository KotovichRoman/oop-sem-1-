using System;

namespace lab5
{
    public abstract class PrintingDevice : Technic
    {
        public PrintingDevice(string name, string developer, bool used) : base(name, developer, used) { }
        public abstract void InfoAboutScanner();
        
        public override string ToString()
        {
            return $"Name: {Name}\nDeveloper: {Developer}\nUsed: {Used}";
        }
    }
}
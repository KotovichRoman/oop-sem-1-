using System;

namespace lab5
{
    sealed class Tablet : Technic
    {
        public Tablet(string name, string developer, bool used) : base(name, developer, used) { }
        
        public override string ToString()
        {
            return $"Name: {Name}\nDeveloper: {Developer}\nUsed: {Used}";
        }
    }
}
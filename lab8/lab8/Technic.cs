using System;

namespace lab8
{
    public class Technic
    {
        public string Name;

        public Technic(string name)
        {
            this.Name = name;
        }
        
        public override string ToString()
        {
            return this.Name;
        }
    }
}
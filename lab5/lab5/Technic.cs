using System;

namespace lab5
{
    public class Technic : IProduct, IInterface
    {
        public string Name { get; set; }
        public string Developer { get; set; }
        
        public bool Used { get; set; }

        public Technic(string name, string developer, bool used)
        {
            this.Name = name;
            this.Developer = developer;
            this.Used = used;
        }

        public void UsedTechnic(bool used)
        {
            if (used)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }

        public virtual bool IsComputer()
        {
            return false;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nDeveloper: {Developer}\nUsed: {Used}";
        }


       
    }
}
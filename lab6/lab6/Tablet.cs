using System;

namespace lab6
{
    sealed class Tablet : Technic
    {
        public Tablet(string name, string developer, bool used, int serviceLife, int price)
            : base(name, developer, used, serviceLife, price)
        {
            this.Name = name;
            this.Developer = developer;
            this.Used = used;
            this.ServiceLife = serviceLife;
            this.Price = price;
        }
        
        public override string ToString()
        {
            return $"Name: {Name}\nDeveloper: {Developer}\nUsed: {Used}";
        }
    }
}
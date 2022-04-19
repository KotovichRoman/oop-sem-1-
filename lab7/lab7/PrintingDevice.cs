using System;

namespace lab7
{
    public abstract class PrintingDevice : Technic
    {
        public PrintingDevice(string name, string developer, bool used, int serviceLife, int price) 
            : base(name, developer, used, serviceLife, price)
        {
            this.Name = name;
            this.Developer = developer;
            this.Used = used;
            this.ServiceLife = serviceLife;
            this.Price = price;
        }

        public abstract void InfoAboutScanner();
        
        public override string ToString()
        {
            return $"Name: {Name}\nDeveloper: {Developer}\nUsed: {Used}";
        }
    }
}
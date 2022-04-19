using System;

namespace lab6
{
    public class Technic : IProduct
    {
        public string Name { get; set; }
        public string Developer { get; set; }
        public bool Used { get; set; }
        public int ServiceLife { get; set; }
        public int Price { get; set; }

        public Technic(string name, string developer, bool used, int serviceLife, int price)
        {
            this.Name = name;
            this.Developer = developer;
            this.Used = used;
            this.ServiceLife = serviceLife;
            this.Price = price;
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
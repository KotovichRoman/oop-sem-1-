using System;

namespace lab7
{
    public class Technic : IProduct
    {
        private int price;
        
        public string Name { get; set; }
        public string Developer { get; set; }
        public bool Used { get; set; }
        public int ServiceLife { get; set; }

        public int Price
        {
            get { return price; }
            set {
                if (value <= 0)
                {
                    throw new PriceException("неа");
                }
                else
                {
                    price = value;
                }
            }
        }

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
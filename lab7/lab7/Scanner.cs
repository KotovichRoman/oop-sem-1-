using System;

namespace lab7
{
    public class Scanner : PrintingDevice
    {
        public string ScannerModel { get; set; }

        public Scanner(string name, string developer, bool used, int serviceLife, int price ,string scannerModel)
            : base(name, developer, used, serviceLife, price)
        {
            this.Name = name;
            this.Developer = developer;
            this.Used = used;
            this.ServiceLife = serviceLife;
            this.Price = price;
            this.ScannerModel = scannerModel;
        }

        public override void InfoAboutScanner()
        {
            Console.WriteLine($"Model: {ScannerModel}");
        }

        public override int GetHashCode()
        {
            Console.WriteLine($"\nHash of {this.Name} is: {Name.GetHashCode()}\n");
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            PrintingDevice el = obj as PrintingDevice;
            if (el as PrintingDevice == null)
                return false;

            return el.Name == this.Name;
        }
        
        public override string ToString()
        {
            return $"Name: {Name}\nDeveloper: {Developer}\nUsed: {Used}\nModel: {ScannerModel}\n";
        }
    }
}
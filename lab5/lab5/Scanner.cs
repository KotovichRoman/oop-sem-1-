using System;

namespace lab5
{
    public class Scanner : PrintingDevice
    {
        public string ScannerModel { get; set; }
        public int ScannerYear { get; set; }
        
        public Scanner(string name, string developer, bool used, string scannerModel, int scannerYear) : base(name, developer, used)
        {
            this.ScannerModel = scannerModel;
            this.ScannerYear = scannerYear;
        }

        public override void InfoAboutScanner()
        {
            Console.WriteLine($"Model: {ScannerModel}\nYear: {ScannerYear}");
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
            return $"Name: {Name}\nDeveloper: {Developer}\nUsed: {Used}\nModel: {ScannerModel}\nYear: {ScannerYear}";
        }
    }
}
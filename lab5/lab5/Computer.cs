using System;

namespace lab5
{
    public class Computer : Technic
    {
        public string ComputerModel { get; set; }
        
        public Computer(string name, string developer, bool used, string computerModel) : base(name, developer, used)
        {
            this.ComputerModel = computerModel;
        }

        public void InfoAboutModel()
        {
            Console.WriteLine($"Model: {ComputerModel}");
        }

        public override bool IsComputer() {
            return true;
        }
        
        public override string ToString()
        {
            return $"Name: {Name}\nDeveloper: {Developer}\nUsed: {Used}\nModel: {ComputerModel}";
        }
    }
}
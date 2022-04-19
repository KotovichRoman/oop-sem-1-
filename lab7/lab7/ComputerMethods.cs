using System;

namespace lab7
{
    public partial class Computer : Technic
    {
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
using System;

namespace lab6
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
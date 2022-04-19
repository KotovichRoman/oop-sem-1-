using System;

namespace lab6 //Товар(интерфейс) -> Техника -> Печатающее устройство -> Сканер
               //                 -> Компьютер
               //                 -> Планшет
{
    class Program
    {
        static void Main()
        {
            EnumTechnic ComputerFromEnum;
            ComputerFromEnum = EnumTechnic.Computer;
            Console.WriteLine("EnumComputer: " + ComputerFromEnum);
            Console.WriteLine("ComputerNumber: " + (int) ComputerFromEnum);

            Laptop laptop = new Laptop("Acer", 4000);

            Laboratory laboratory = new Laboratory();
            
            Tablet tablet = new Tablet("technic1", "TechnicDeveloper", true, 4, 4000);
            Computer computer1 = new Computer("computer1", "ComputerDeveloper1", true, 5, 3000, "ComputerModel1");
            Computer computer2 = new Computer("computer2", "ComputerDeveloper2", false, 9, 5000,"ComputerModel2");
            PrintingDevice print = new Scanner("Scanner1", "Developer1", false, 5, 6000, "hp");
            
            laboratory.AddItem(tablet);
            laboratory.AddItem(computer1);
            laboratory.AddItem(computer2);
            laboratory.AddItem(print);
            
            Controller.LowPrice(laboratory.container);
            Controller.CountTypeTechnic(laboratory.container);
            Controller.FindOlderTechnic(laboratory.container);
        }
    }
}
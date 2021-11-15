using System;

namespace lab5 //Товар(интерфейс) -> Техника -> Печатающее устройство -> Сканер
               //                            -> Компьютер
               //                            -> Планшет
{
    class Program
    {
        static void Main()
        {
            Technic technic = new Technic("technic1", "TechnicDeveloper", true);
            technic.UsedTechnic(technic.Used);
            technic.IsComputer();

            Technic computer1 = new Computer("computer1", "ComputerDeveloper1", true, "ComputerModel1");
            Computer computer2 = new Computer("computer2", "ComputerDeveloper2", false, "ComputerModel2");
            computer2.IsComputer();

            if (computer2 is Computer)
            {
                Console.WriteLine("Yes");
            }

            if (technic is Scanner)
            {
                Console.WriteLine("No");
            }

            PrintingDevice print = new Scanner("Scanner1", "Developer1", false, "hp", 10);
            if (print is PrintingDevice)
            {
                Scanner scanner = print as Scanner;
            }

            Printer printing = new Printer();
            printing.IamPrinting(technic);
            printing.IamPrinting(computer1);
            printing.IamPrinting(computer2);
            printing.IamPrinting(print);

            ((IProduct)technic).OneNamedMethod();
            ((IInterface)technic).OneNamedMethod();

            
        }
    }
}
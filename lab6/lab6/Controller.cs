using System;
using System.Collections.Generic;
using System.Data;

namespace lab6
{
    public static class Controller
    {
        public static void FindOlderTechnic(List<Technic> list)
        {
            int yearNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < list.Count; i++)
            {
                if (yearNumber < list[i].ServiceLife)
                {
                    Console.WriteLine(list[i].Name);
                }
            }
        }

        public static void CountTypeTechnic(List<Technic> list)
        {
            int computerCount = 0;
            int printingDeviceCount = 0;
            int tabletCount = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Computer)
                {
                    computerCount++;
                }

                if (list[i] is PrintingDevice)
                {
                    printingDeviceCount++;
                }

                if (list[i] is Tablet)
                {
                    tabletCount++;
                }
            }

            Console.WriteLine($"Computers: {computerCount}\nPrintingDevices: {printingDeviceCount}\nTablets: {tabletCount}");
        }

        public static void LowPrice(List<Technic> list)
        {
            list.Sort();
            Console.WriteLine(list);
        }
    }
}
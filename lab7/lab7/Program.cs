using System;
using System.Runtime.InteropServices;

namespace lab7
{
    class Program
    {
        static void Main()
        {
            Computer computer = new Computer("", "", true, 0, 0, "");
            
            try
            {
                Technic technic = new Technic("", "", true, 2, -1000);
            }
            catch (PriceException error)
            {
                Console.WriteLine(error.Message);
            }

            try
            {
                computer.Price = 5000;
                if (computer.Price > 6000)
                {
                    throw new Exception("неа");
                }
            }
            catch (PriceException error)
            {
                Console.WriteLine(error.Message);
                throw;
            }

            try
            {
                int a = 5;
                int b = a / 0;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                int a = 5;
                int b = a;
                Console.WriteLine("finally");
            }

            try
            {
                string[] s = new string[2];
                s[1] = "Hello";
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            try
            {
                string str = null;
                if (str == null)
                {
                    throw new Exception("неа");
                }
            }
            catch (NullReferenceException error)
            {
                Console.WriteLine(error.Message);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine(error.TargetSite);
                Console.WriteLine(error.Source);
                Console.WriteLine(error.StackTrace);
            }
            finally
            {
                Console.WriteLine("универсалочка");
            }
        }
    }
}
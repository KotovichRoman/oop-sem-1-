

using System;

namespace lab5
{
    public interface IProduct
    {
        void UsedTechnic(bool used);

        virtual void OneNamedMethod() 
        {
            Console.WriteLine("h");
        }

       
    }
}
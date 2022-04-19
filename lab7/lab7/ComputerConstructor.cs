using System.Diagnostics;

namespace lab7
{
    public partial class Computer : Technic
    {
        private string computerModel;
        public string ComputerModel
        {
            get { return computerModel; }
            set
            {
                if (value == "")
                {
                    Debug.Assert(value == "");
                }
                else
                {
                    computerModel = value;
                }
            }
        }
        
        public Computer(string name, string developer, bool used, int serviceLife, int price , string computerModel) 
            : base(name, developer, used, serviceLife, price)
        {
            this.Name = name;
            this.Developer = developer;
            this.Used = used;
            this.ServiceLife = serviceLife;
            this.Price = price;
            this.ComputerModel = computerModel;
        }
    }
}
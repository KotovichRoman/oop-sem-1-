namespace lab6
{
    public partial class Computer : Technic
    {
        public string ComputerModel { get; set; }
        
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
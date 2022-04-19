namespace lab7
{
    public struct Laptop
    {
        public string Model { get; set; }
        public int Price { get; set; }

        public Laptop(string model, int price)
        {
            this.Model = model;
            this.Price = price;
        }
    }
}
using System;
using System.Collections.Generic;

namespace lab6
{
    public class Laboratory
    {
        public List<Technic> container { get; set; }

        public Laboratory()
        {
            container = new List<Technic>();
        }

        public Technic this[int index]
        {
            get { return container[index]; }
            set { container[index] = value; }
        }

        public void AddItem(Technic tech) => container.Add(tech);
        public void DeteleItem(Technic tech) => container.Remove(tech);

        public void Print()
        {
            for (int i = 0; i < container.Count; i++)
            {
                Console.WriteLine(" " + container[i].Name);
            }
        }
    }
}
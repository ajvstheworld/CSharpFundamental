using System;
namespace Quiz
{
    public abstract class Television
    {
        public string Price { get; set; }
        public string Size { get; set; }
        public int Ports { get; set; } = 4;

        public Television(string price, string size, int ports)
        {
            this.Price = price;
            this.Size = size;
            this.Ports = ports;
        }

        public void MountTelevision(bool isTrue)
        {
            if (isTrue)
            {
                Console.WriteLine("The TV is mounted.");
            }
            else
            {
                Console.WriteLine("The TV is not mounted.");
            }
        }
    }
}
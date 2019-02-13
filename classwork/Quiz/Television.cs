using System;
namespace Quiz
{
    public abstract class Television
    {
        public string Price { get; set; }
        public string Size { get; set; } = "60 inch";
        public int Ports { get; set; } = 4;
        public bool IsMountable { get; set; }

        public abstract void TurnOn();
        public abstract void SmartApp();

        public Television(string price, string size, int ports, bool isMountable)
        {
            this.Price = price;
            this.Size = size;
            this.IsMountable = isMountable;
            this.Ports = ports;
        }

        public void Mountable(bool isMountable)
        {
            if (isMountable)
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
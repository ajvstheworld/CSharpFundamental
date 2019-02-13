using System;
namespace Quiz
{
    public class HDTV : Television
    {
        public int ports = 8;
        public HDTV(string price, string size) : base(price, size)
        {
            Console.WriteLine("The price of the HDTV is " + price);
            Console.WriteLine("The size of the HDTV is " + size);
        }


    }
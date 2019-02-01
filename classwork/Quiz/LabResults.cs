using System;
namespace Quiz
{
    public class LabResults
    {
        public void Method1()
        {
            int myVal1 = 25, myVal2 = 100;
            int voltage = myVal1 * myVal2;
            Console.WriteLine("The voltage of the object is " + voltage);
        }

        public void Method2()
        {
            int myVal2 = 100, myVal3 = 2500;
            int current = myVal3 / myVal2;
            Console.WriteLine("The current of the object is " + current);
        }

        public void Method3()
        {
            int myVal1 = 25, myVal3 = 2500;
            int resistance = myVal3 / myVal1;
            Console.WriteLine("The resistance of the object is " + resistance);
        }
    }
}
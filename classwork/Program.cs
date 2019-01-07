using System;using System;
using Lessons;
/*This namespace represents the file folder that
the class is in. */
namespace classwork
{
    // Class is a blueprint of an object.
    class Program
    {
        /*static is only one, void is a return type
        Main is the method name, string[] is an array and a parameter */
        static void Main(string[] args)
        {
            // Console is a class, WriteLine is a method with a parameter
            //Console.WriteLine("Hello World!");
            //MyHouseResults();
            //MyNumericExamples();
            //OtherNumericExamples();
            //MyStringExamples();
            //StatementSamples();
            BottlesSong();
        }

        static void StatementSamples ()
        {
            //StatementExamples se = new StatementExamples();
            //se.SampleIf();
            //se.SampleIfElse();
            //se.SampleIfChain();
            //se.SampleIfAnd();
            //se.SampleIfOr();
            //se.SampleConditional();
            //se.SampleSwitch(10);
            //se.SampleWhile();
            //se.SampleForEach();
            //string myString = se.JumpStatementExample("Sunday");
            //Console.WriteLine(myString);
        }

        static void BottlesSong()
        {
            BottlesOfBeer beer = new BottlesOfBeer();
            string song = beer.BottlesOfBeerSong();
            Console.WriteLine(song);
        }

        static void MyStringExamples()
        {
            StringTypes myTypes = new StringTypes();
            myTypes.SampleString();
            myTypes.AddString();
            string words = myTypes.StringBuilderExample("Get", "It", "On");

            Console.WriteLine(words);
            myTypes.CharTypeExample();
            myTypes.EscapeExample();
            myTypes.PlaceHolderExample();
            myTypes.ArraySample();
            myTypes.MyHouseArray();
            myTypes.MultiArraySample();
        }

        static void MyNumericExamples()
        {
            NumericTypes myTypes = new NumericTypes();
            myTypes.GetSomeType();

            int something = myTypes.ConvertFloatToInt(35.9F);
            Console.WriteLine(something);

            Console.WriteLine(myTypes.LongFromInt(5600));
            myTypes.BasicMath();
            myTypes.CheckOperators();
            myTypes.IncrementDecrement();
            myTypes.SpecialValues();
            myTypes.ComparisonOperators();

        }

        static void OtherNumericExamples()
        {
            NumericTypes myTypes = new NumericTypes();
            myTypes.OtherOperators();
        }

        static void MyHouseResults()
        {
            // Created and object instance of House called myHouse
            House myHouse = new House();
            // This sets the value of Red to the object
            myHouse.PaintDoor = "Red";
            myHouse.CloseDoor(); // the door closes
            // This gets the value of Red from the object
            Console.WriteLine(myHouse.PaintDoor); // red
            // This is a second object instance of House.
            House mySecondHouse = new House();
            mySecondHouse.PaintDoor = "green";
            Console.WriteLine(mySecondHouse.PaintDoor); // green
            Console.WriteLine(myHouse.PaintDoor); // red
        }
    }
}
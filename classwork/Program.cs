using System;
using Lessons;
using Quiz;
/*This namespace represents the file folder that
the class is in. */
namespace classwork
{
    // Class is a blueprint of an object.
    class Program
    {
        /*static is only one, void is a return type
        Main is the method name, string[] is an array and a parameter */
        static void Main(string[] args) =>
            //Console.WriteLine("Hello World!");
            //MyHouseResults();
            //MyNumericExamples();
            //OtherNumericExamples();
            //MyStringExamples();
            //StatementSamples();
            //BottlesSong();
            //MyVideoGame();
            //HouseSample();
            //StructSample();
            //QuizWork1();
            //FruitSample();
            // ParamsSample();
            // ModifierExamples();
            // Lesson12();
            //AbstractDemo();
            //DeconstructSample();
            //FinalizerSample();
            //IndexerSample();
            //PartialSample();
            //AnotherHouseExample();
            //CollectionSample();
            LabResults();

        static void LabResults()
        {
            LabResults myLab = new LabResults();
            myLab.Method1();
            myLab.Method2();
            myLab.Method3();
        }
        static void CollectionSample()
        {
            CollectionExamples ce = new CollectionExamples();
            ce.MyArrayListExample();
        }

        static void GenericSample()
        {
            GenericList<int> myList = new GenericList<int>();
            myList.Add(10);

            GenericList<string> mySecondList = new
            GenericList<string>();
            mySecondList.Add("Happy");

            GenericList<TRex> myTrexList = new
            GenericList<TRex>();
            myTrexList.Add(new TRex());
        }

        static void AnotherHouseExample()
        {
            House myHouse = new House()
            {
                Roof = "Shingles",
                Window = "Double Pane",
                PaintDoor = "Red",
                Foundation = "Concrete"
            };

            Console.WriteLine("My windows choice is {0}", myHouse.Window);
        }

        static void PartialSample()
        {
            Pear pear = new Pear("Yellow");
        }

        static void IndexerSample()
        {
            IndexerExample indexerExample = new IndexerExample();

            indexerExample[2] = 250;

            for (int i = 0; i < indexerExample.Length; i++)
            {
                Console.WriteLine("Value {0} = {1}", i, indexerExample[i]);

            }
        }

        static void FinalizerSample()
        {
            FinalizerExample finalExample = new FinalizerExample("John", "Doe");

        }

        static void DeconstructSample()
        {
            string first = "Tom", last = "Jones";

            Lesson13 lesson13 = new Lesson13("John", "Doe");

            Console.WriteLine("First Name = {0} and Last Name = {1}", first, last);

            lesson13.Deconstruct(out first, out last);

            Console.WriteLine("First Name = {0} and Last Name = {1}", first, last);
        }

        static void AbstractDemo()
        {
            TRex trex = new TRex();
            Triceratops triceratops = new Triceratops();

            trex.EatFood();
            trex.Move();
            trex.SkinType();

            triceratops.EatFood();
            triceratops.Move();
            triceratops.Teeth();
        }

        static void Lesson12()
        {
            double temp = Utilities.CelsiusToFahrenheit("43.2");
            double temp2 = Utilities.FahrenheitToCelsius("109.76");
            Console.WriteLine(temp);
            Console.WriteLine(temp2);
        }

        static void ModifierExamples()
        {
            int test = 14;
            Lesson11 myLesson = new Lesson11();
            myLesson.RefSample(ref test);
            Console.WriteLine(test);

            string first, second, middle;
            myLesson.OutSample("John Doe Riley", out first, out second, out middle);

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(middle);
        }

        static void ParamsSample()
        {
            Lesson11 lesson = new Lesson11();
            lesson.UseParams(10, 3, 24, 36, 45, 120);

            lesson.UseParams();

            int[] intArray = { 2, 3, 4, 5, 6 };
            lesson.UseParams(intArray);

            lesson.UseParams2(1, "Happy", false, 34.5F);

            lesson.OptionalParam("Roger");
            lesson.OptionalParam("Matthew", 19);

        }

        static void FruitSample()
        {
            Apple myApple = new Apple();
            myApple.EatFruit();

            Fruit myFruit = new Apple();
            myFruit.EatFruit();

            Orange myOrange = new Orange();
            myOrange.EatFruit();

            RanchStyle ranch = new RanchStyle("Stone", "Triple Pane", "Composite", "Blue");
            ranch.OpenDoor();
            Console.WriteLine(ranch.Roof);
        }


        static void QuizWork1()
        {
            QuizClass1 myQuiz = new QuizClass1();
            string result = myQuiz.GetGradeMessage('A');
            Console.WriteLine(result);
            myQuiz.DivisibleByThree5();
        }

        static void StructSample()
        {
            BookSample bookSample = new BookSample(4.99m, "Fallout Bible", "Chris Avallone");
            Console.WriteLine("The book " + bookSample.title + " by " + bookSample.author + " is $" + bookSample.price);
        }
        static void HouseSample()
        {
            House myHouse = new House("concrete", "triple pane");
            Console.WriteLine(myHouse.PaintDoor);
            Console.WriteLine(myHouse.Foundation);
            myHouse.OpenDoor(true);
        }

        static void StatementSamples()
        {
            StatementExamples se = new StatementExamples();
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
            se.SampleDays(DaysOfWeek.Wed);
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

        static void MyVideoGame()
        {
            VideoGame myVideoGame = new VideoGame();
            myVideoGame.OpenPlasticCase();
            myVideoGame.ClosePlasticCase();
            myVideoGame.EnterDisc();
            myVideoGame.RemoveDisc();
            myVideoGame.ApplyCoverArt();
            myVideoGame.RemoveCoverArt();
            myVideoGame.ReadManual();
            myVideoGame.StopReadingManual();
        }
    }
}
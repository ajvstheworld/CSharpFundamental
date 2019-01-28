using System;
using System.Collections;
namespace Lessons
{
    public class CollectionExamples
    {
        public void MyArrayListExample()
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add("Hello");
            myArrayList.Add("World");
            myArrayList.Add(42);
            myArrayList.Add(84);

            Console.WriteLine("Count = {0}", myArrayList.Count);

            myArrayList.Remove(42);
            myArrayList.RemoveAt(0);

            Console.WriteLine("Count = {0}", myArrayList.Count);

            myArrayList.Add("Other");
            myArrayList.Add("Stuff");
            //myArrayList.Sort();

            foreach (Object item in myArrayList)
            {
                Console.WriteLine("Type = {0}", item);
            }
        }
    }
}
using System;
using System.Text;
namespace Lessons
{
    public class StringTypes
    {
        private string _testString = "Test String";
        private string _secondString = "Second String";

        public void SampleString () 
        {
            Console.WriteLine(_testString);
        }

        public void AddString() 
        {
            Console.WriteLine(_testString + _secondString);
        }

        public string StringBuilderExample(string value1, string value2, string value3) 
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(value1)
            .Append(" ").Append(value2)
            .Append(" ").Append(value3);

            return builder.ToString();
        }   

        public void CharTypeExample()
        {
            Char ab = 'A';
            Char de = 'B';
            char copyrightSymbol = '\u00A9';
            char hi = (char)88;

            Console.WriteLine(hi);
            Console.WriteLine(ab == de);
        }
    }
}
using System;
namespace Lesson014_HT_Task3
{
    public class Book
    {
        public class Note
        {
            string text = "";
            public string Text
            {
                get { return text; }
                set { text += value + "\n"; }
            }
        }
        public void FindNext(string str)
        {
            Console.WriteLine("String searching: " + str);
        }
    }
}

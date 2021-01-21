using System;

namespace Lesson014_HT_Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Book.Note note = new Book.Note();
            note.Text = "Searched";
            note.Text = "Line";
            Console.WriteLine(note.Text);
        }
    }
}

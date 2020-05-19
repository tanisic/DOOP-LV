using System;
using System.Collections.Generic;

namespace LV6
{
    class Program
    { //1. zadatak
        static void Main(string[] args)
        {
            List<Note> notes = new List<Note>();
            for(int i=0;i<3;i++)
            {
                notes.Add(new Note("title", "text"));
            }
            Notebook notebook = new Notebook(notes);
            Iterator iterator = (Iterator)notebook.GetIterator();
            while(!iterator.IsDone)
            {
                iterator.Current.Show();
                iterator.Next();
            }
        }
    }
}

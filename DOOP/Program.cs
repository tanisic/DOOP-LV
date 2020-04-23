using System;

namespace DOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Note note1 = new Note();
            note1.SetText("Zabiljeska1");
            Note note2 = new Note("Ivan Markovic");
            note2.SetText("Ivanova zabiljeska");
            Note note3 = new Note("Antina zabiljeska", "Anto Antic", 2);
            Console.WriteLine(note1.ToString());
            Console.WriteLine(note2.ToString());
            Console.WriteLine(note3.ToString());

            NoteWithDate note4 = new NoteWithDate("Note4", "Marijan", 1);
            NoteWithDate note5 = new NoteWithDate("Note5", "Marko", 0);
            ToDoList Lista = new ToDoList();
            Lista.AddTask(note1);
            Lista.AddTask(note2);
            Lista.AddTask(note3);
            Lista.AddTask(note4);
            Lista.AddTask(note5);
            foreach (Note note in Lista.GetToDoList())
            {
                Console.WriteLine(note.ToString());
            }
        }
    }
}

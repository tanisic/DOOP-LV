using System;

namespace DOOP
{
    class Program
    {
        static void Main(string[] args)
        {  //3. zadatak
            Note note1 = new Note();
            note1.SetText("Zabiljeska1");
            Note note2 = new Note("Ivan Markovic");
            note2.SetText("Ivanova zabiljeska");
            Note note3 = new Note("Antina zabiljeska", "Anto Antic", 2);
            Console.WriteLine(note1.ToString());
            Console.WriteLine(note2.ToString());
            Console.WriteLine(note3.ToString());

            // 7. zadatak
            ToDoList Lista = new ToDoList();

            for (int i=0;i<3;i++){
                Console.WriteLine("Unesite tekst zabiljeske: ");
                string text = Console.ReadLine();
                Console.WriteLine("Unesite autora zabiljeske: ");
                string author = Console.ReadLine();
                Console.WriteLine("Unesite vaznost zabiljeske [0,1,2]: ");
                int importance;
                do{
                    importance = Convert.ToInt32(Console.ReadLine());
                } while (importance>2||importance<0);

                Lista.AddTask(new NoteWithDate(text, author, importance));
            }
            
            foreach (Note note in Lista.GetToDoList()){
                Console.WriteLine(note.ToString());
            }

            Lista.FinishHighPriorityTasks();

            Console.WriteLine("Lista nakon izvršavanja: \n");
            foreach (Note note in Lista.GetToDoList())
            {
                Console.WriteLine(note.ToString());
            }


        }
    }
}

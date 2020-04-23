using System;
using System.Collections.Generic;
using System.Text;

namespace DOOP
{
    class ToDoList
    {
        public List<Note> List = new List<Note>();

        public void AddTask(Note note)
        {
            List.Add(note);

        }

        public void FinishTask(Note note)
        {

            if (List.Contains(note))
            {
                List.RemoveAt(List.IndexOf(note));
            }

        }
        public List<Note> GetToDoList()
        {
            return List;
        }
    }
}

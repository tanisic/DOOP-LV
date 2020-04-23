using System.Collections.Generic;
using System.Linq;

namespace DOOP
{
    class ToDoList:IToDoList
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

        public Note GetTask(int index)
        {
        if (List.Count < index || index < 0)
        {
        return null;
        }
        return List.ElementAt(index);
        }

        public List<Note> GetToDoList()
        {
         return List;
        }
    }
}

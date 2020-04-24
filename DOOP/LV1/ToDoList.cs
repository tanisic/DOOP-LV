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
            List.RemoveAt(List.IndexOf(note));    
        }

        public Note GetTask(int index)
        { 
            return List.ElementAt(index);
        }

        public List<Note> GetToDoList()
        {
         return List;
        }

        public void FinishHighPriorityTasks()
        {
            for(int i=0;i<List.Count;i++)
            {
                if (GetTask(i).GetImportance() == (Importance)2)
                {
                    FinishTask(GetTask(i));
                    i--;
                }
            }
        }
    }
}

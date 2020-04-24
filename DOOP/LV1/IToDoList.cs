using System;
using System.Collections.Generic;
using System.Text;

namespace DOOP
{
    public interface IToDoList
    {
        public void AddTask(Note note);
        public void FinishTask(Note note);
        public List<Note> GetToDoList();
        public Note GetTask(int index);
        public void FinishHighPriorityTasks();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoNetFrameworkBackend.Models;

namespace ToDoNetFrameworkBackend.DAL
{
    public class Repository
    {
        public List<TaskToDo> GetAllTask()
        {
            using (var db = new TodoContext())
            {
                return db.TaskToDo.ToList();
            }
        }

        public void InsertTask(TaskToDo task)
        {
            using (var db = new TodoContext())
            {
                db.TaskToDo.Add(task);
                db.SaveChanges();                
            }
        }
    }
}
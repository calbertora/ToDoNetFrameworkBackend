using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public TaskToDo Get(int id)
        {
            using (var db = new TodoContext())
            {
                return db.TaskToDo.Find(id);
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

        public void Update(TaskToDo task)
        {
            using (var db = new TodoContext())
            {
                db.Set<TaskToDo>().Attach(task);
                db.Entry(task).State = EntityState.Modified;
                db.SaveChanges();
            }
            
        }
    }
}
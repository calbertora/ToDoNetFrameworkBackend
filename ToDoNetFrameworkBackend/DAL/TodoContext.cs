using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoNetFrameworkBackend.Models;

namespace ToDoNetFrameworkBackend.DAL
{
    public class TodoContext: DbContext
    {
        public TodoContext() : 
            base("ToDoContext")
        {

        }

        public DbSet<TaskToDo> TaskToDo { get; set; }
    }
}
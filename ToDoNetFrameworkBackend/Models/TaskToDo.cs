using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoNetFrameworkBackend.Models
{
    public class TaskToDo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDoNetFrameworkBackend.DAL;
using ToDoNetFrameworkBackend.Models;

namespace ToDoNetFrameworkBackend.Controllers
{
    public class TaskController : ApiController
    {
        private Repository reposiotry;

        public IEnumerable<TaskToDo> Get()
        {
            return reposiotry.GetAllTask();
        }

        public void Post(TaskToDo task)
        {
            reposiotry.InsertTask(task);
        }
    }
}

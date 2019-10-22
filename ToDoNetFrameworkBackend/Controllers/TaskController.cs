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
        private Repository repository;

        public TaskController()
        {
            this.repository = new Repository();
        }

        [HttpGet]
        public IEnumerable<TaskToDo> Get()
        {
            return repository.GetAllTask();
        }

        [HttpGet]
        public TaskToDo Get(int id)
        {
            return repository.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] TaskToDo task)
        {
            repository.InsertTask(task);
        }

        public IHttpActionResult Put([FromBody] TaskToDo task)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repository.Update(task);
                    return Ok("The User has been updated");
                }
                else
                {
                    return BadRequest("Couldn't update");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

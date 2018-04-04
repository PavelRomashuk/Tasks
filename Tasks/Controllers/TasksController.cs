using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tasks.Common.Contracts;
using Tasks.Models.Models;

namespace Tasks.Controllers
{
    public class TasksController : ApiController
    {
        IRepository repo = null;
        // GET api/<controller>
        public IEnumerable<Task> Get()
        {
            return repo.GetAllTasks();
        }

        // GET api/<controller>/5
        public Task Get(Guid id)
        {
            return repo.GetTaskById(id);
        }

        // POST api/<controller>
        public void Post([FromBody]Task value)
        {
            repo.UpdateTask(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Task value)
        {
            repo.InsertTask(value);
        }

        // DELETE api/<controller>/5
        public void Delete(Guid id)
        {
            repo.DeleteTaskById(id);
        }
    }
}
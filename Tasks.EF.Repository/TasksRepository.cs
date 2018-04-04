using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tasks.Common.Contracts;
using Tasks.Models.Models;

namespace Tasks.EF.Repository
{
    public class TasksRepository : IRepository
    {
        public void DeleteTaskById(Guid id)
        {
            using (TasksDB db = new TasksDB())
            {
                Task task = db.Tasks.FirstOrDefault(x => x.Id == id);
                if (task == null)
                    throw new Exception($"Task with id {id} not found!");
                else
                {
                    db.Tasks.Remove(task);
                    db.SaveChanges();
                }
            }
        }

        public List<Models.Models.Task> GetAllTasks()
        {
            using (TasksDB db = new TasksDB())
            {
                return db.Tasks.ToList();
            }
        }

        public Models.Models.Task GetTaskById(Guid id)
        {
            using (TasksDB db = new TasksDB())
            {
                return db.Tasks.FirstOrDefault(x => x.Id == id);
            }
        }

        public Models.Models.Task InsertTask(Models.Models.Task task)
        {
            using (TasksDB db = new TasksDB())
            {
                Task result = db.Tasks.Add(task);
                db.SaveChanges();
                return result;
            }
        }

        public void SetTaskAsCompletetd(Guid id)
        {
            using (TasksDB db = new TasksDB())
            {
                Task task = db.Tasks.FirstOrDefault(x => x.Id == id);
                if (task == null)
                    throw new Exception($"Task with id {id} not found!");

                task.Finished = true;
                db.SaveChanges();
            }
        }

        public Models.Models.Task UpdateTask(Models.Models.Task task)
        {
            using (TasksDB db = new TasksDB())
            {
                Task taskToUpdate = db.Tasks.FirstOrDefault(x => x.Id == task.Id);
                if (task == null)
                    throw new Exception($"Task with id {task.Id} not found!");

                taskToUpdate.Description = task.Description;
                taskToUpdate.Finished = task.Finished;
                db.SaveChanges();
                return taskToUpdate;
            }
        }
    }
}

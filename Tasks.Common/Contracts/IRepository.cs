using System;
using System.Collections.Generic;
using Tasks.Models.Models;

namespace Tasks.Common.Contracts
{
    public interface IRepository
    {
        List<Task> GetAllTasks();
        Task GetTaskById(Guid id);
        Task InsertTask(Task task);
        void DeleteTaskById(Guid id);
        void SetTaskAsCompletetd(Guid id);
        Task UpdateTask(Task task);
    }
}

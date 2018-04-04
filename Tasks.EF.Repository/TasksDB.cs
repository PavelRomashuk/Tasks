using System.Data.Entity;
using Tasks.Models.Models;

namespace Tasks.EF.Repository
{
    public class TasksDB: DbContext
    {
        public TasksDB(): this("name=TasksDB")
        {
        }

        public TasksDB(string connectionString): base(connectionString)
        {

        }

        public virtual DbSet<Task> Tasks { get; set; }
    }
}

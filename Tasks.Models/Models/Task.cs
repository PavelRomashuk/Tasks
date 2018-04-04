using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Models.Models
{
    public class Task
    {
        public Guid Id { get; set; }
        public String Description { get; set; }
        public bool Finished { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public String CreatedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Final_Prj.Models
{
    public abstract class  TaskEntity
    {
         public int Id { get; set; } //Quản lý id của task bằng Id của user
         public string TaskName { get; set; }
         public string Description { get; set; }
         public DateTime DueDate { get; set; }   //deadline  
         public string Status { get; set; }
         public string Priority { get; set; }
        public TaskEntity (int id, string taskName, string description, DateTime dueDate, string status, string priority)
        {
            Id = id;
            TaskName = taskName;
            Description = description;
            DueDate = dueDate;
            Status = status;
            Priority = priority;
        }
        public TaskEntity()
        {
        }
    }
}

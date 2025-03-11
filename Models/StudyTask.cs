using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Prj.Repository;

namespace Final_Prj.Models
{
    class StudyTask : Task
    {
        private TaskRepository taskRepository;
        private User User;
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }   //deadline  
        public string Status { get; set; }
        public string Priority { get; set; }
        public String Subject { get; set; }  //Môn học
        public StudyTask(int id, string taskName, string description, DateTime dueDate, string status, string priority, User user, string subject)
        {
            this.taskRepository = new TaskRepository();
            this.User = user;
            this.Id = id;
            this.TaskName = taskName;
            this.Description = description;
            this.DueDate = dueDate;
            this.Status = status;
            this.Priority = priority;
            this.User = user;
            this.Subject = subject;

        }
        public StudyTask()
        {
        }


    }
}

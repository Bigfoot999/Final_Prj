using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Prj.Repository;

namespace Final_Prj.Controllers
{
    public abstract class TaskController
    {
        private TaskRepository taskRepository;

        public TaskController()
        {
            this.taskRepository = new TaskRepository();
        }
        public String AddTask(StudyTask task)
        {
            return taskRepository.AddTask(task);
        }
    }
}
